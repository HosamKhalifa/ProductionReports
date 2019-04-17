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
using DevExpress.XtraBars;

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
                if (ActiveChildForm is CoreLib.IMenuController)
                {
                    var menuButtons = (CoreLib.IMenuController)ActiveChildForm;

                    bool formState = ActiveChildForm.HasChanges();
                    menuButtons.EnableSaveButton(formState);
                }                
            };
        }
        public static void LookupFormRefOpen(CoreLib.Grid.ViewDetailsEventArgs e)
        {
            var form = e.GridColumnInfo.ColumnLablel.LookupFormRef;
            if (form == CoreLib.MyEnums.FormEntityEnum.None) return;
            Args _args = e.GridColumnInfo.FormArgs;
            OpenLinkToFormEntity(form,_args);

        }
        #endregion

        #region Init menus
        public static void BuildNavBarLinks(NavBarControl _navCtrl,DevExpress.Xpo.UnitOfWork _session)
        {
            var infoList = UIFormInfo.GetOrBuildFormEntityList(_session);
            foreach (NavBarItem link in _navCtrl.Items.Where(x => x.Tag != null)) //Tag foreach Link item must have FormEntity Enum value represent Form name
            {
                CoreLib.MyEnums.FormEntityEnum frmName = (CoreLib.MyEnums.FormEntityEnum)link.Tag;
                var dbRow = infoList.Where(x => x.FormEntity == (int)frmName).FirstOrDefault();
                //link.Name = dbRow.FormName;
                link.Caption = dbRow.LinkCaption;
               
                link.LinkClicked += (s, e) => 
                {
                    var sender = (NavBarItem)s;
                    var linkCode = (CoreLib.MyEnums.FormEntityEnum)sender.Tag;
                    Args _args = new Args()
                    {
                        Caller = MdiParentForm
                    };
                    OpenLinkToFormEntity(linkCode,_args);
                };
            }

        }

        private static void OpenLinkToFormEntity(CoreLib.MyEnums.FormEntityEnum _linkTag,CoreLib.Args _args)
        {
            
            switch (_linkTag)
            {
                case CoreLib.MyEnums.FormEntityEnum.TestForm:
                    MenuController.TestFormOpen();
                    break;
                case CoreLib.MyEnums.FormEntityEnum.FieldsSetting:
                    MenuController.FieldsSettingFormOpen();
                    break;
                case CoreLib.MyEnums.FormEntityEnum.Sequence:
                    MenuController.SequenceFormOpen(_args);
                    break;
                case CoreLib.MyEnums.FormEntityEnum.UILabel:
                    MenuController.UILabelFormOpen();
                    break;
                case CoreLib.MyEnums.FormEntityEnum.TableBase:
                    MenuController.TableBaseFormOpen();
                    break;
                case CoreLib.MyEnums.FormEntityEnum.Currency:
                    MenuController.CurrencyFormOpen(_args);
                    break;
                case CoreLib.MyEnums.FormEntityEnum.CurrencySetup:
                    MenuController.CurrencySetupFormOpen(_args);
                    break;
                case CoreLib.MyEnums.FormEntityEnum.FiscalCalender:
                    MenuController.FiscalCalenderFormOpen(_args);
                    break;
                case CoreLib.MyEnums.FormEntityEnum.FiscalCalenderYear:
                    MenuController.FiscalCalenderYearFormOpen(_args);
                    break;
                case CoreLib.MyEnums.FormEntityEnum.LedgerChartOfAccounts:
                    MenuController.LedgerChartOfAccountsFormOpen(_args);
                    break;
                case CoreLib.MyEnums.FormEntityEnum.MainAccountType:
                    MenuController.MainAccountTypeFormOpen(_args);
                    break;
                default:
                    break;
            }

        }
        public static void BuildFunctionLinks(BarManager _barMgr)
        {
            _barMgr.ItemClick += (s, e) => 
            {
                var item = e.Item;
               
                if (item.Tag == null || !(item.Tag is CoreLib.MyEnums.MainFunction)) return;
                var function = (CoreLib.MyEnums.MainFunction)item.Tag;
                RunFunction(function);
                
            };
            
        }
        public static void RunFunction(CoreLib.MyEnums.MainFunction _function)
        {
            switch (_function)
            {
                case CoreLib.MyEnums.MainFunction.Save:
                    Save();
                    break;
                case CoreLib.MyEnums.MainFunction.NewRecord:
                    break;
                case CoreLib.MyEnums.MainFunction.DeleteRecord:
                    break;
                case CoreLib.MyEnums.MainFunction.Print:
                    break;
                case CoreLib.MyEnums.MainFunction.Retrieve:
                    Retrieve();
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

        #region Open Methods
        public static void MainAccountTypeFormOpen(Args _args)
        {
            //Simple form expect calss type passed in Args.ObjectParm
            _args.ParmObject = typeof(MainAccountType);
            SimpleForm frm = new MyEditor.SimpleForm(_args) { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        public static void LedgerChartOfAccountsFormOpen(Args _args)
        {
            //Simple form expect calss type passed in Args.ObjectParm
            _args.ParmObject = typeof(LedgerChartOfAccounts);
            SimpleForm frm = new MyEditor.SimpleForm(_args) { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        public static void CurrencySetupFormOpen(Args _args)
        {
            //Curreny will use runtime Master - Details form
              var parms = new MyEditor.MasterDetailsParm()
              {
                  MasterClass = typeof(CurrencyPair),
                  MasterKeyName = "LineId",
                  Details = typeof(CurrencyPairExchangeRate),
                  DetailsKeyName = "CurrencyPair",
                  KeyType = KeyTypeEnum.Object
              };
            _args.ParmObject = parms;
            MasterDetailsForm frm = new MasterDetailsForm(_args)
            { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();

           

        }
        public static void CurrencyFormOpen(Args _args)
        {
            //Simple form expect calss type passed in Args.ObjectParm
            _args.ParmObject = typeof(Currency);
            SimpleForm frm = new MyEditor.SimpleForm(_args) { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        public static void SequenceFormOpen(Args _args)
        {
            //Simple form expect calss type passed in Args.ObjectParm
            _args.ParmObject = typeof(Sequence);
            SimpleForm frm = new MyEditor.SimpleForm(_args) { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        public static void FieldsSettingFormOpen()
        {
            var frm = new CoreLib.Label.FieldsSettingsFrm() { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            //Double click event
            frm.ObjectTree.DoubleClick += (s, e) =>
            {
                var treeList1 = (DevExpress.XtraTreeList.TreeList)s; 
                DevExpress.XtraTreeList.TreeListHitInfo hi = treeList1.CalcHitInfo(treeList1.PointToClient(Control.MousePosition));
                if (hi.Node != null)
                {
                    var objType = hi.Node["ObjectType"] ?? "";
                    var objId = hi.Node["Id"] ?? "";
                    var objName = hi.Node["Name"] ?? "";

                    if (objType.ToString() == "Table")
                    {
                        var currObj = (CoreLib.Label.UIObjectBase)frm.UIObjectBaseXPC.Lookup(objId);
                        Args _args = new Args() { ParmObject = currObj.ObjectType() };
                        SimpleForm simpleFrm = new SimpleForm(_args)
                        {
                            WindowState = FormWindowState.Maximized,
                            Text = currObj.ObjectName
                        };
                        simpleFrm.ShowDialog();
                    }
                }
            };

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
        public static void FiscalCalenderFormOpen(Args _args)
        {
            //Simple form expect calss type passed in Args.ObjectParm
            _args.ParmObject = typeof(FiscalCalendar);
            SimpleForm frm = new MyEditor.SimpleForm(_args) { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        public static void FiscalCalenderYearFormOpen(Args _args)
        {
            //Curreny will use runtime Master - Details form
            var parms = new MyEditor.MasterDetailsParm()
            {
                MasterClass = typeof(FiscalCalenderYear),
                MasterKeyName = "LineId",
                Details = typeof(FiscalCalenderPeriod),
                DetailsKeyName = "FiscalCalenderYear",
                KeyType=KeyTypeEnum.Object
            };
            _args.ParmObject = parms;
            MasterDetailsForm frm = new MasterDetailsForm(_args)
            { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();



        }
        #endregion

        #region MdiParent Tool bar 
        public static void Save()
        {
            var frm = ((MyForm)MdiParentForm.ActiveMdiChild);
            frm?.SaveChangesWithAsk(frm.unitOfWork1);
        }
        public static void Retrieve()
        {
            ActiveChildForm?.Retrieve();            
        }
        #endregion

    }
}
