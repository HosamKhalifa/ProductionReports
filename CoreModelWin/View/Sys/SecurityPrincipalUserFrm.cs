using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreModelWin.View.Sys
{
    public partial class SecurityPrincipalUserFrm : CoreLib.MyForm
    {
        public SecurityPrincipalUserFrm()
        {
            InitializeComponent();
        }
        public SecurityPrincipalUserFrm(CoreLib.Args _args):base(_args)
        {
            InitializeComponent();
            InitObj();
        }

        private void InitObj()
        {
            AppLists.AppListInfo l = new AppLists.AppListInfo(unitOfWork1);
            l.LinkLookupsToGrid(userGV, userXPC);
            userGV.ClassInfo = typeof(CoreModel.SecurityPrincipalUser);
        }
    }
}
