using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CoreLib.Label;
using DevExpress.Data.Filtering;
using DevExpress.XtraLayout;
using CoreModel;

namespace CoreModelWin.View.GL
{
    public partial class MainAccount : CoreLib.MyForm
    {
        public MainAccount()
        {
            InitializeComponent();
        }
        public MainAccount(CoreLib.Args _args) : base(_args)
        {
            InitializeComponent();
            this.Args = _args;
            InitObj();
        }

        #region Properties
        BindingManagerBase bindingMgr;
        #endregion

        private void InitObj()
        {
            bindingMgr = this.BindingContext[mainActXPC];
            AppLists.AppListInfo l = new AppLists.AppListInfo(unitOfWork1);
            l.LinkToDataLayout(dataLayoutControl1, mainActXPC);

            l.LinkListToColumn(cOALookUpEdit, typeof(CoreModel.LedgerChartOfAccounts));

            cOALookUpEdit.EditValueChanged += (s, e) =>
            {
                var selected = (LedgerChartOfAccounts)cOALookUpEdit.GetSelectedDataRow();
                mainActXPC.Criteria = new BinaryOperator(new OperandProperty("LedgerChartOfAccounts"), new OperandValue(selected), BinaryOperatorType.Equal);
                mainActXPC.LoadingEnabled = true;
            };
        }
        public override void NewRecord()
        {
            var cOA = cOALookUpEdit.GetSelectedDataRow();
            if (cOA == null)
            {
                SetStatusBarText("Please select chart of accounts before proceed");
                return;
            }
            base.NewRecord();
            if (SaveChangesWithAsk(unitOfWork1))
            {
                //var newLine = new CoreModel.MainAccount(unitOfWork1) { LedgerChartOfAccounts = (LedgerChartOfAccounts)cOA };
                //mainActXPC.Add(newLine);
                
                bindingMgr.AddNew();
                var newLine = (CoreModel.MainAccount)bindingMgr.Current;
                newLine.LedgerChartOfAccounts = (LedgerChartOfAccounts)cOA;
            }

        }
        public override bool DeleteRecord()
        {
            if (base.DeleteRecord() )
            {
                var current = (CoreModel.MainAccount)bindingMgr.Current;
                current.Delete();
                unitOfWork1.CommitChanges();
                return true;
            }
            return false;
            
        }

    }
}
