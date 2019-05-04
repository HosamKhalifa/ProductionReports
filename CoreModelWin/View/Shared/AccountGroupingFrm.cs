using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreModelWin.View.Shared
{
    public partial class AccountGroupingFrm : CoreLib.MyForm
    {
        public AccountGroupingFrm()
        {
            InitializeComponent();
            accountGroupingXUC1.InitObj(unitOfWork1);
        }
    }
}
