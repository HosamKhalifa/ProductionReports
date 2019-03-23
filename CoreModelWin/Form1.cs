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
namespace CoreModelWin
{
    public partial class Form1 : CoreLib.MyForm
    {
        public Form1()
        {
            InitializeComponent();
            InitMyForm();
            InitConn();
            SkinManage();

            InitSystemSetupEventHandlers();//System setup menu event handlers
        }

        private void InitMyForm()
        {
            
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
                user.ReadConnection("Nour", "Nour");

                XpoDefault.DataLayer = XpoDefault.GetDataLayer(user.ConnectionString, DevExpress.Xpo.DB.AutoCreateOption.SchemaOnly);
                SecurityUser.CurrentUser = user;
                SecurityUser.IsConnected = true;


                Session s = new Session();
                List<XPClassInfo> lst = new List<XPClassInfo>()
                {
                    Session.DefaultSession.GetClassInfo(typeof(CoreLib.Grid.UserProfile.UIMaster)),
                    Session.DefaultSession.GetClassInfo(typeof(CoreLib.Grid.UserProfile.UIParams)),
                    Session.DefaultSession.GetClassInfo(typeof(CoreLib.Grid.UserProfile.UIProfile)),
                    Session.DefaultSession.GetClassInfo(typeof(CoreLib.Grid.UserProfile.UIProfileLine))

                };
                //s.UpdateSchema();
                
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
                uILabelLink.LinkClicked += (s, e) => //LabelEditor
                {
                    CoreLib.Label.LabelEditorFrm frm = new CoreLib.Label.LabelEditorFrm("CoreLib;CoreModel") { MdiParent = this };
                    frm.Show();
                };
                tableBaseLink.LinkClicked += (s, e) => //TableBase 
                {
                  
                        TableBaseFrm frm = new TableBaseFrm() { MdiParent = this };
                        frm.Show();
                  
                };
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            }
            
            
        }
    }
}
