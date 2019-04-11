using CoreLib;
using CoreModelWin.MyEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreModel;
using System.Windows.Forms;
using DevExpress.XtraNavBar;

namespace CoreModelWin
{
   public class MenuController
    {
// Register menu items steps
//1 Controller will has Navigation bar  reference 
//2 Loop for each FormInfo record 
//Search if navigation has link named as FormEntity Enum name
//If found will start to settings link gui and icons + add event handlers for link click that call Generic Open method

        #region Members
        private static MyForm fActiveChildForm;

        public static MyForm ActiveChildForm
        {
            get { return fActiveChildForm; }
            set { fActiveChildForm = value; }
        }
        private static MyForm fMdiParentForm;
        public static MyForm MdiParentForm
        {
            get { return fMdiParentForm; }
            set { RegisterMdiParent(value); }
        }
        private static void RegisterMdiParent(MyForm _mdiParent)
        {
            fMdiParentForm = _mdiParent;
           
            
            fMdiParentForm.MdiChildActivate += (s, e) =>//Link active mdiChild
            {
                ActiveChildForm = (MyForm)fMdiParentForm.ActiveMdiChild;
                if (ActiveChildForm is IMenuController)
                {
                    var menuButtons = (IMenuController)ActiveChildForm;

                    bool formState = ActiveChildForm.HasChanges();
                    menuButtons.EnableSaveButton(formState);
                }                
            };
        }
        #endregion
        #region Init menus
        public static void BuildNavBarLinks(NavBarControl _navCtrl,DevExpress.Xpo.UnitOfWork _session)
        {
            var infoList = UIFormInfo.GetOrBuildFormEntityList(_session);
            foreach (NavBarItem link in _navCtrl.Items.Where(x => x.Tag != null)) //Tag foreach Link item must have FormEntity Enum value represent Form name
            {
                UIFormInfo.FormEntityEnum frmName = (UIFormInfo.FormEntityEnum)link.Tag;
                var dbRow = infoList.Where(x => x.FormEntity == (int)frmName).FirstOrDefault();
                //link.Name = dbRow.FormName;
                link.Caption = dbRow.LinkCaption;
               
                link.LinkClicked += (s, e) => 
                {
                    var sender = (NavBarItem)s;
                    var linkCode = (UIFormInfo.FormEntityEnum)sender.Tag;
                    OpenLinkToFormEntity(linkCode);
                };
            }

        }

        private static void OpenLinkToFormEntity(UIFormInfo.FormEntityEnum _linkTag)
        {
            switch (_linkTag)
            {
                case UIFormInfo.FormEntityEnum.TestForm:
                    MenuController.TestFormOpen();
                    break;
                case UIFormInfo.FormEntityEnum.FieldsSetting:
                    MenuController.FieldsSettingFormOpen();
                    break;
                case UIFormInfo.FormEntityEnum.Sequence:
                    MenuController.SequenceFormOpen();
                    break;
                case UIFormInfo.FormEntityEnum.UILabel:
                    MenuController.UILabelFormOpen();
                    break;
                case UIFormInfo.FormEntityEnum.TableBase:
                    MenuController.TableBaseFormOpen();
                    break;
                case UIFormInfo.FormEntityEnum.FiscalCalender:
                    MenuController.FiscalCalenderFormOpen();
                    break;
                case UIFormInfo.FormEntityEnum.Currency:
                    MenuController.CurrencyFormOpen();
                    break;
                case UIFormInfo.FormEntityEnum.CurrencySetup:
                    MenuController.CurrencySetupFormOpen();
                    break;
                default:
                    break;
            }

        }

        private static void TestFormOpen()
        {
            TestFrm frm = new TestFrm() { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        #endregion
        public static void CurrencySetupFormOpen()
        {
            //Curreny will use runtime Master - Details form
              var args = new MasterDetailsForm.FormParms()
              {
                  MasterClass = typeof(CurrencyPair),
                  MasterKeyName = "LineId",
                  Details = typeof(CurrencyPairExchangeRate),
                  DetailsKeyName = "CurrencyPair",
                  IsKeyValueNumeric = true
              };
            MasterDetailsForm frm = new MasterDetailsForm(args)
            { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();

           

        }
        public static void CurrencyFormOpen()
        {
        }
        public static void SequenceFormOpen()
        {
            SimpleForm frm = new MyEditor.SimpleForm(typeof(Sequence)) { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        public static void FieldsSettingFormOpen()
        {
            var frm = new CoreLib.Label.FieldsSettingsFrm() { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        public static void UILabelFormOpen()
        {
            CoreLib.Label.LabelEditorFrm frm = new CoreLib.Label.LabelEditorFrm("CoreLib;CoreModel") { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }

        public static void TableBaseFormOpen()
        {
            TableBaseFrm frm = new TableBaseFrm() { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }

        public static void FiscalCalenderFormOpen()
        {
            SimpleForm frm = new MyEditor.SimpleForm(typeof(FiscalCalendar)) { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
    }
}
