using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreModelWin.View.Sales
{
    public partial class AccountBaseLineXUC : CoreModelWin.MyEditor.SalesCanvasXUC
    {
        public AccountBaseLineXUC()
        {

            InitializeComponent();
        }
        #region
        public void InitObj(BindingSource _accountBindingSource)
        {
            

        }
        #endregion
        public BindingSource AccountBaseBS
        {
            get { return accountBaseBS; }
            set
            {
                accountBaseBS = value;
                dataLayoutControl1.DataSource = accountBaseBS;
                
            }
        }

    }
}
