using CoreLib.Grid;
using CoreModel;
using CoreModelWin.Properties;
using DevExpress.LookAndFeel;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using CoreLib.SharedExt;
using DevExpress.XtraBars.Docking2010.Customization;

namespace CoreModelWin
{
    public partial class Form1 : CoreLib.MyForm,IMenuController
    {
        public Form1()
        {
            InitializeComponent();
            LinkMenuController(); // Should be at first call stack


            InitMyForm();
            InitConn();
            //This form will use MenuController to be event handlers foreach menu item 
            //Register this form as MdiParent in MenuController 
            MenuController.MdiParentForm = this;
            MenuController.BuildNavBarLinks(navBarControl1, unitOfWork1);
           
           
            InitBarButtons();
            SkinManage();

            //InitSystemSetupEventHandlers();//System setup menu event handlers
            
        }

        private void LinkMenuController()
        {
            //Assign FormEntity enum to link tag to link linkItem to its OpenForm methods
            currencyCodeLink.Tag = UIFormInfo.FormEntityEnum.Currency;
            currencySetupLink.Tag = UIFormInfo.FormEntityEnum.CurrencySetup;
            tableBaseLink.Tag = UIFormInfo.FormEntityEnum.TableBase;
            fieldsSettingsLink.Tag = UIFormInfo.FormEntityEnum.FieldsSetting;
            uILabelLink.Tag = UIFormInfo.FormEntityEnum.UILabel;
            sequenceLink.Tag = UIFormInfo.FormEntityEnum.Sequence;


        }

        private void InitBarButtons()
        {
            refreshBI.ItemClick += (s, e) => 
            {
                if(CoreLib.FormRecord.CurrentRecord != null)
                {
                    CoreLib.FormRecord.CurrentRecord.Reload();
                }
            };
        }

        private void InitMyForm()
        {
            //Lang menu
            langBI.EditValueChanged += (s, e) => 
            {
                CoreLib.GlobalMethods.UILang = langBI.EditValue.ToString();
            };
        }
        public override void SetStatusBarText(string txt = "OK")
        {
            statusBarTxt.Caption = txt;
            base.SetStatusBarText(txt);
        }
        private void InitConn()
        {
            try
            {
                SecurityUser user = new SecurityUser();
                user.ReadConnection("Norran", "Norran");

                XpoDefault.DataLayer = XpoDefault.GetDataLayer(user.ConnectionString, DevExpress.Xpo.DB.AutoCreateOption.SchemaOnly);
                SecurityUser.CurrentUser = user;
                SecurityUser.IsConnected = true;


                #region OldCode
                //List<XPClassInfo> lst = new List<XPClassInfo>()
                //{
                //    Session.DefaultSession.GetClassInfo(typeof(CoreLib.Grid.UserProfile.UIMaster)),
                //    Session.DefaultSession.GetClassInfo(typeof(CoreLib.Grid.UserProfile.UIParams)),
                //    Session.DefaultSession.GetClassInfo(typeof(CoreLib.Grid.UserProfile.UIProfile)),
                //    Session.DefaultSession.GetClassInfo(typeof(CoreLib.Grid.UserProfile.UIProfileLine))

                //};
                //s.UpdateSchema();
                #endregion
                Session s = new Session();
                Assembly a = Assembly.GetAssembly(typeof(CoreLib.MyForm));
                var asseblyLst = AppDomain.CurrentDomain.GetAssemblies().
                    Where(x => x.FullName.Contains("Model") || x == a);
                foreach (var item in asseblyLst)
                {
                    s.UpdateSchema(item);
                }
               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SkinManage()
        {
           
            UserLookAndFeel.Default.SkinName = Settings.Default["AppSkinName"].ToString();
            this.FormClosing += (s, e) =>
            {
                Settings.Default["AppSkinName"] = UserLookAndFeel.Default.SkinName;
                Settings.Default.Save();
            };
        }

        private void InitSystemSetupEventHandlers()
        {
            try
            {
                fiscalCalenderLink.LinkClicked += (s, e) => { MenuController.FiscalCalenderFormOpen(); };
                currencyCodeLink.LinkClicked += (s, e) =>
                {
                    MenuController.CurrencyFormOpen();
                };
                currencySetupLink.LinkClicked += (s, e) =>
                {
                    MenuController.CurrencySetupFormOpen();
                };
                sequenceLink.LinkClicked += (s, e) =>
                {
                    MenuController.SequenceFormOpen();
                };

                testBI.ItemClick += (s, e) => //Test
                {
                    TestFrm frm = new TestFrm() { MdiParent = this, WindowState = FormWindowState.Maximized };
                    frm.Show();
                };

                fieldsSettingsLink.LinkClicked += (s, e)=>
                {
                    MenuController.FieldsSettingFormOpen();
                };

                uILabelLink.LinkClicked += (s, e) => //LabelEditor
                {
                    MenuController.UILabelFormOpen();
                   
                };
                tableBaseLink.LinkClicked += (s, e) => //TableBase 
                {
                    MenuController.TableBaseFormOpen();
                };
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }
            
            
        }
        #region IMenu interface
        public void EnableSaveButton(bool _settings)
        {
            saveBarButtonItem.Enabled = _settings;
        }

        public void EnableDeleteButton(bool _settings)
        {
            delBarButtonItem.Enabled = _settings;
        }

        public void EnableAddButton(bool _settings)
        {
            addBarButtonItem.Enabled = _settings;
        }

        public void EnableEditButton(bool _settings)
        {
            editBarButtonItem.Enabled = _settings;
        }
        #endregion
    }
}
