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
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

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
                case CoreLib.MyEnums.FormEntityEnum.AccountGrouping:
                    MenuController.AccountGroupingFormOpen();
                    break;
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
                case CoreLib.MyEnums.FormEntityEnum.MainAccount:
                    MenuController.MainAccountFormOpen(_args);
                    break;
                case CoreLib.MyEnums.FormEntityEnum.Customer:
                    MenuController.CustomerFormOpen(_args);
                    break;
                case CoreLib.MyEnums.FormEntityEnum.Vendor:
                    MenuController.VendorFormOpen(_args);
                    break;
                case CoreLib.MyEnums.FormEntityEnum.Country:
                    MenuController.CountryFormOpen(_args);
                    break;
                case CoreLib.MyEnums.FormEntityEnum.City:
                    MenuController.CityFormOpen(_args);
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
                    NewRecord();
                    break;
                case CoreLib.MyEnums.MainFunction.DeleteRecord:
                    DeleteRecord();
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
        public static void AccountGroupingFormOpen()
        {
            var frm = new View.Shared.AccountGroupingFrm() { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        #region Open Methods
        public static void CityFormOpen(Args _args)
        {
            //Curreny will use runtime Master - Details form
            var parms = new MyEditor.MasterDetailsParm()
            {
                MasterClass = typeof(Province),
                MasterKeyName = "LineId",
                Details = typeof(City),
                DetailsKeyName = "Province",
                KeyType = KeyTypeEnum.Object,
                MasterGVEditMode = CoreLib.MyEnums.GridViewEditMode.SimpleEdit,
                DetailsGVEditMode = CoreLib.MyEnums.GridViewEditMode.FormEdit
            };
            _args.ParmObject = parms;
            MasterDetailsForm frm = new MasterDetailsForm(_args)
            { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();

        }
        public static void CountryFormOpen(Args _args)
        {
            //Simple form expect calss type passed in Args.ObjectParm
            _args.ParmObject = typeof(Country);
            SimpleForm frm = new MyEditor.SimpleForm(_args) { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        public static void CustomerFormOpen(Args _args)
        {
            _args.Caller = _args.Caller == null ? MdiParentForm : _args.Caller;
            _args.ParmEnumType = typeof(TableBase.TableEnum);
            _args.ParmEnumValue = (int)TableBase.TableEnum.Customer;
            View.Shared.AccountBase frm = new View.Shared.AccountBase(_args) { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        public static void VendorFormOpen(Args _args)
        {
            _args.Caller = _args.Caller == null ? MdiParentForm : _args.Caller;
            _args.ParmEnumType = typeof(TableBase.TableEnum);
            _args.ParmEnumValue = (int)TableBase.TableEnum.Vendor;
            View.Shared.AccountBase frm = new View.Shared.AccountBase(_args) { MdiParent = MdiParentForm, WindowState = FormWindowState.Maximized };
            frm.Show();
        }
        public static void MainAccountFormOpen(Args _args)
        {
            _args.Caller = _args.Caller == null?MdiParentForm:_args.Caller;
            View.GL.MainAccount frm = new View.GL.MainAccount(_args) { MdiParent=MdiParentForm,WindowState=FormWindowState.Maximized};
            frm.Show();
        }
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
            frm.MainGridView.EnableAutoSave = true;
            var actionBtn = new DevExpress.XtraBars.BarButtonItem()
            {
                Name = "TestSequence",
                Glyph = DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/showproduct_16x16.png")
            };
            frm.MainBar.AddItem(actionBtn);
            actionBtn.ItemClick += (s, e) =>
            {
                if(FormRecord.CurrentRecord != null && CoreLib.FormRecord.CurrentRecord  is Sequence)
                {
                    var line = (Sequence)FormRecord.CurrentRecord;
                    MessageBox.Show(line.NextValue(FormRecord.EffectiveDate));
                }
            };
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
        public static void NewRecord()
        {
            ActiveChildForm?.NewRecord();
        }
        public static bool? DeleteRecord()
        {
            return ActiveChildForm?.DeleteRecord();
        }

        //Approve menu setup

        public static void ApproveMenuSetup(Session _uOW,DevExpress.XtraBars.PopupMenu _appMenu)
        {
            XPCollection wflowSteps = new XPCollection(_uOW , typeof(WorkflowStep));
            
            foreach (WorkflowStep action in wflowSteps)
            {
                _appMenu.AddItem(new DevExpress.XtraBars.BarButtonItem()
                {
                    Name = action.WorkflowStepName.Replace(" ", string.Empty),
                    Caption = action.WorkflowStepName,
                    Enabled = false,
                    Tag = action,
                    Visibility = BarItemVisibility.Never
                }).Item.ItemClick+=(s,e)=> 
                {
                    if(CoreLib.FormRecord.CurrentRecord != null && CoreLib.FormRecord.CurrentRecord is Line)
                    {
                        (CoreLib.FormRecord.CurrentRecord as Line).SetWorkflowStatus(action.NextWorkflow);
                    }
                };
            }
        }
        public static void ApproveMenuActivated(PopupMenu approvePopupMenu)
        {
            //Hide all menu buttons
            foreach (BarButtonItemLink btn in approvePopupMenu.ItemLinks)
            {
                btn.Item.Visibility = BarItemVisibility.Never;
                btn.Item.Enabled = false;
            }
            var current = (Line)CoreLib.FormRecord.CurrentRecord;
            var lst = WorkflowStep.GetCurrentRecordOption(current);
            foreach (var item in lst)
            {
                var btn = approvePopupMenu.ItemLinks.Where(x => x.Item.Name == item.WorkflowStepName.Replace(" ", string.Empty)).FirstOrDefault();
                if(btn != null)
                {
                    btn.Item.Visibility = BarItemVisibility.Always;
                    btn.Item.Enabled = true;
                }
            }
            
        }

        #endregion

    }
}
