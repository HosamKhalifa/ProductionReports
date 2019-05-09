using CoreLib;
using CoreModel;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreModelWin.View.Shared
{
    public partial class AccountBase : CoreLib.MyForm
    {
        public AccountBase(Args _args ):base(_args)
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            if(Args.ParmEnumType == typeof(TableBase.TableEnum) && Args.ParmEnumValue > 0)
            {
                AccountType = (TableBase.TableEnum)Args.ParmEnumValue;
                Type t = TableBase.GetTable(unitOfWork1, AccountType).GetTableType();
                
                accountBaseXPC = new XPCollection(unitOfWork1, t) ;

                accountBaseBS.DataSource = accountBaseXPC;
                accountBaseLineXUC2.AccountBaseBS = this.accountBaseBS;
                this.accountBaseBS.ResetBindings(true);
                accountBaseLineXUC2.AccountBaseBS.ResetBindings(true);

                accountBaseGV.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Default;
                accountBaseLineXUC2.InitObj(unitOfWork1);
                /*
                    var filter = new BinaryOperator(new OperandProperty("TableId"), new OperandValue(AccountType), BinaryOperatorType.Equal);
                    accountBaseXPC.Criteria = filter;
                    accountBaseXPC.LoadingEnabled = true;
                 */
            }
        }

        #region Properties
        public TableBase.TableEnum AccountType { get; set; }
        #endregion

        #region Methods
        public override void NewRecord()
        {
            //var tab = new Sales.AccountBaseLineXUC();
            //tab.InitObj(unitOfWork1,accountBaseXPC, null);
            //MyEditor.SimpleForm frm = new MyEditor.SimpleForm() ;
            //frm.Args = new Args() { Caller = this };
            //frm.Show();
            accountBaseGV.AddNewRow();
            base.NewRecord();

        }
        #endregion
    }
}
