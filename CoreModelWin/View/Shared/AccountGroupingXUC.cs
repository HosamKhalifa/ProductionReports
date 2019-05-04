using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace CoreModelWin.View.Shared
{
    public partial class AccountGroupingXUC :MyEditor.SalesCanvasXUC
    {
        public AccountGroupingXUC()
        {
            InitializeComponent();
        }
        CoreModel.MyEnums.AccountType currentActivatedAccType;
        public void InitObj(UnitOfWork _uOw )
        {
            unitOfWork1 = _uOw;
            accountTypeImageCombo.Properties.AddEnum(typeof(CoreModel.MyEnums.AccountType));
            accountTypeImageCombo.EditValueChanged += (s, e) => 
            {
                currentActivatedAccType = (CoreModel.MyEnums.AccountType)accountTypeImageCombo.EditValue;
                ActivateAccountType(currentActivatedAccType);
            };
            grpXPC.CollectionChanged += (s, e) => 
            {
                ((CoreModel.AccountGroup)e.ChangedObject).AccountType = currentActivatedAccType;
            };
            
        }
        public void ActivateAccountType(CoreModel.MyEnums.AccountType _type)
        {
            grpXPC.Criteria = new BinaryOperator(new OperandProperty("AccountType"), new OperandValue(_type), BinaryOperatorType.Equal);
            grpXPC.LoadingEnabled = true;
            
        }

    }
}
