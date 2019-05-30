using DevExpress.Data.Filtering;
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
            groupGV.ClassInfo = typeof(CoreModel.SecurityPrincipalRoleOU);
            userGroupsGV.ClassInfo = typeof(CoreModel.SecurityPrincipalRoleOUMembers);
            groupUsersGV.ClassInfo = typeof(CoreModel.SecurityPrincipalRoleOUMembers);

            //Users master grid setup
            //userGV.FocusedRowChanged += (s, e) =>
            //{
            //    try
            //    {
            //        if (e.FocusedRowHandle < 0) return;
            //        var userLine = (CoreModel.SecurityPrincipalUser)userGV.GetRow(e.FocusedRowHandle);

            //        CriteriaOperator criteria = new BinaryOperator(new OperandProperty("User"), new OperandValue(userLine), BinaryOperatorType.Equal);
            //        detailsXPC.Criteria = criteria;
            //        detailsXPC.LoadingEnabled = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        XtraMessageBox.Show(ex.GetFullExceptionErrMessage());
            //    }

            //};

        }
    }
}
