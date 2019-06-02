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

namespace CoreModelWin.View.Sys
{
    public partial class SecurityRoleJournalXUC : MyEditor.SystemCanvasXUC
    {
        public SecurityRoleJournalXUC()
        {
            InitializeComponent();
           
        }

        private void InitObj()
        {
            roleJournalGV.ClassInfo = typeof(CoreModel.SecurityPrincipalRoleJournalMembers);
            AppLists.AppListInfo l = new AppLists.AppListInfo(unitOfWork1);
            l.LinkLookupsToGrid(roleJournalGV, RoleJournalXPC);

        }

        public void RetrieveRoleMembers(UnitOfWork _uOW,CoreModel.JournalBase _journal)
        {
            unitOfWork1 = _uOW;
            InitObj();//Setup grid lookups and labels

            CoreModel.SecurityPrincipalRoleJournal roleJour = CoreModel.SecurityPrincipalRoleJournal.FindOrCreateJournal(unitOfWork1,_journal);
            if(roleJour == null)
            {
                throw new Exception("Role journal could not found or create new one has been failed");
            }
            roleJournalGV.InitNewRow += (s, e) =>
            {
                var x = (CoreModel.SecurityPrincipalRoleJournalMembers)roleJournalGV.GetRow(e.RowHandle);
                x.RoleJournal = roleJour;
            };

            var crt = new BinaryOperator("RoleJournal", roleJour, BinaryOperatorType.Equal);
            RoleJournalXPC.Session = _uOW;
            RoleJournalXPC.Criteria = crt;
            RoleJournalXPC.LoadingEnabled = true;
        }
    }
}
