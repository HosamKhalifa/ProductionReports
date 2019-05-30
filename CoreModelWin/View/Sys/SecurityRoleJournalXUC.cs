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

        }

        public void RetrieveRoleMembers(CoreModel.JournalBase _journal)
        {
            CoreModel.SecurityPrincipalRoleJournal roleJour = CoreModel.SecurityPrincipalRoleJournal.FindOrCreateJournal(unitOfWork1,_journal);
            if(roleJour == null)
            {
                throw new Exception("Role journal could not found or create new one");
            }
            roleJournalGV.InitNewRow += (s, e) =>
            {
                var x = (CoreModel.SecurityPrincipalRoleJournalMembers)roleJournalGV.GetRow(e.RowHandle);
                x.RoleJournal = roleJour;
            };

            var crt = new BinaryOperator("RoleJournal", roleJour, BinaryOperatorType.Equal);
            RoleJournalXPC.Criteria = crt;
            RoleJournalXPC.LoadingEnabled = true;
        }
    }
}
