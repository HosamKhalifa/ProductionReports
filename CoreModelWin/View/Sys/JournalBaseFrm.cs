using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreModelWin.View.Sys
{
    public partial class JournalBaseFrm : CoreLib.MyForm
    {
        public JournalBaseFrm()
        {
            InitializeComponent();
        }
        public JournalBaseFrm(CoreLib.Args _args):base(_args)
        {
            InitializeComponent();
            InitObj();
        }

        private void InitObj()
        {
            journalGV.ClassInfo = typeof(CoreModel.JournalBase);
            AppLists.AppListInfo l = new AppLists.AppListInfo(unitOfWork1);
            l.LinkLookupsToGrid(journalGV,journalXPC);
            var preList = new AppLists.AppListPredefined();
            preList.LinkList(new AppLists.ListColumnInfo(colWorkflowStatus) , CoreModel.MyEnums.AppListPredefined.WorkflowStatusCombo);
            preList.LinkList(new AppLists.ListColumnInfo(colSequenceWorkflowStatus), CoreModel.MyEnums.AppListPredefined.WorkflowStatusCombo);

        }
    }
}
