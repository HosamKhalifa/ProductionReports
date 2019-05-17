using CoreModel;
using CoreModelWin.AppLists;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreModelWin.View.Shared
{
    public partial class AccountBaseXUC : CoreModelWin.MyEditor.SystemCanvasXUC
    {
        public AccountBaseXUC()
        {
            InitializeComponent();
            
        }
        #region Methods
        public void InitObj(UnitOfWork _uOW,Type _accountClassType)
        {
            unitOfWork1 = _uOW;

            AccountType = Account.TranslateTableEnumToActType(_accountClassType);

            actBaseXPC = new XPCollection(_uOW, _accountClassType);
            actBaseBS.DataSource = actBaseXPC;
            actBaseBS.ResetBindings(true);

            //InitPrimaryGroup( _uOW,AccountType);
            //InitRef1(_uOW, AccountType);
            //InitRef2(_uOW, AccountType);
            AppLists.AppListInfo l = new AppLists.AppListInfo(_uOW);
            l.LinkToDataLayout(dataLayoutControl1, actBaseXPC);
            
            //Overview grid setup
            AppLists.AppListPredefined preAppList = new AppLists.AppListPredefined();
            var grpWhere = new BinaryOperator(new OperandProperty("AccountType"), new OperandValue(AccountType), BinaryOperatorType.Equal);
            preAppList.LinkList(new ListColumnInfo() {GridColumn= colGroupId , LookUpEditor = GroupIdTreeListLookUpEdit}, MyEnums.AppListPredefined.AccountGroupTree, grpWhere);
            preAppList.LinkList(new ListColumnInfo() { GridColumn = colReferenceNumber1, LookUpEditor=ReferenceNumber1TreeListLookUpEdit }, MyEnums.AppListPredefined.AccountRef1Tree, grpWhere);
            preAppList.LinkList(new ListColumnInfo() { GridColumn = colReferenceNumber2 ,LookUpEditor=ReferenceNumber2TreeListLookUpEdit}, MyEnums.AppListPredefined.AccountRef2Tree, grpWhere);
            preAppList.LinkList(new ListColumnInfo() { GridColumn = colWorkflowStatusInt }, MyEnums.AppListPredefined.WorkflowStatusCombo);
            l.LinkListToColumn(colCountry, typeof(CoreModel.Country),_valueMember: "CountryCode");
            l.LinkListToColumn(colCity, typeof(CoreModel.City),_valueMember: "CityCode");
                      

        }

        private void InitPrimaryGroup( UnitOfWork _uOW, MyEnums.AccountType accountType)
        {
            //unitOfWork1 = _uOW;
            //GroupIdPopupContainerEdit.Properties.PopupControl = new DevExpress.XtraEditors.PopupContainerControl();
            
            //var grpXUC = new View.Shared.AccountGroupingXUC();
            //grpXUC.InitObj(_uOW);
            //grpXUC.ActivateAccountType(accountType);
            //grpXUC.Dock = DockStyle.Fill;
            //GroupIdPopupContainerEdit.Properties.PopupControl.Controls.Add(grpXUC);
            //GroupIdPopupContainerEdit.Properties.PopupControl.Size = new Size(702, 310);
            //grpXUC.LookUp(typeof(CoreModel.AccountGroup), accountType);
            //GroupIdPopupContainerEdit.Properties.ShowPopupCloseButton = true;
            //GroupIdPopupContainerEdit.CloseUp += (s, e) =>
            //{
            //    if (grpXUC.SelectedRow != null)
            //    {
            //        e.Value = ((CoreModel.Line)grpXUC.SelectedRow).LineId;
            //        e.AcceptValue = true;
                    
            //    }
            //    else
            //    {
            //        e.Value = null;
            //    }
            //};
            //GroupIdPopupContainerEdit.DoubleClick += (s, e) => { MessageBox.Show(GroupIdPopupContainerEdit.Text); };

           
        }
        private void InitRef1(UnitOfWork _uOW, MyEnums.AccountType accountType)
        {
            //unitOfWork1 = _uOW;
            //ReferenceNumber1PopupContainerEdit.Properties.PopupControl = new DevExpress.XtraEditors.PopupContainerControl();
            //var grpXUC = new View.Shared.AccountGroupingXUC();
            //grpXUC.InitObj(_uOW);
            //grpXUC.ActivateAccountType(accountType);
            //grpXUC.Dock = DockStyle.Fill;
            //ReferenceNumber1PopupContainerEdit.Properties.PopupControl.Controls.Add(grpXUC);
            //ReferenceNumber1PopupContainerEdit.Properties.PopupControl.Size = new Size(702, 310);
            //grpXUC.LookUp(typeof(CoreModel.AccountRef1), accountType);
            //ReferenceNumber1PopupContainerEdit.Properties.ShowPopupCloseButton = true;
            //ReferenceNumber1PopupContainerEdit.CloseUp += (s, e) =>
            //{
            //    if (grpXUC.SelectedRow != null)
            //    {
            //        e.Value = ((CoreModel.Line)grpXUC.SelectedRow).LineId;
            //        e.AcceptValue = true;
            //    }
            //    else
            //    {
            //        e.Value = null;
            //    }
            //};
            //ReferenceNumber1PopupContainerEdit.DoubleClick += (s, e) => { MessageBox.Show(ReferenceNumber1PopupContainerEdit.Text); };
        }
        private void InitRef2(UnitOfWork _uOW, MyEnums.AccountType accountType)
        {
            //unitOfWork1 = _uOW;
            //ReferenceNumber2PopupContainerEdit.Properties.PopupControl = new DevExpress.XtraEditors.PopupContainerControl();
            //var grpXUC = new View.Shared.AccountGroupingXUC();
            //grpXUC.InitObj(_uOW);
            //grpXUC.ActivateAccountType(accountType);
            //grpXUC.Dock = DockStyle.Fill;
            //ReferenceNumber2PopupContainerEdit.Properties.PopupControl.Controls.Add(grpXUC);
            //ReferenceNumber2PopupContainerEdit.Properties.PopupControl.Size = new Size(702, 310);
            //grpXUC.LookUp(typeof(CoreModel.AccountRef2), accountType);
            //ReferenceNumber2PopupContainerEdit.Properties.ShowPopupCloseButton = true;
            //ReferenceNumber2PopupContainerEdit.CloseUp += (s, e) =>
            //{
            //    if (grpXUC.SelectedRow != null)
            //    {
            //        e.Value = ((CoreModel.Line)grpXUC.SelectedRow).LineId;
            //        e.AcceptValue = true;
            //    }
            //    else
            //    {
            //        e.Value = null;
            //    }
            //};
            //ReferenceNumber2PopupContainerEdit.DoubleClick += (s, e) => { MessageBox.Show(ReferenceNumber2PopupContainerEdit.Text); };
        }

        #endregion
        #region Properties
        public MyEnums.AccountType AccountType
        {
            get;set;
        }
        #endregion

    }
}
