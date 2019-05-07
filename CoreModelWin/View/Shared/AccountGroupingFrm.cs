using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;

namespace CoreModelWin.View.Shared
{
    public partial class AccountGroupingFrm : CoreLib.MyForm
    {
        public AccountGroupingFrm()
        {
            InitializeComponent();
            accountGroupingXUC1.InitObj(unitOfWork1);
        }
        public override bool SaveChangesWithAsk(UnitOfWork unitOfWork)
        {
            return base.SaveChangesWithAsk(unitOfWork);
        }
    }
}
