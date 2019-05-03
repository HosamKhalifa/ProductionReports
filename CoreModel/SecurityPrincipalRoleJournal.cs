using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class SecurityPrincipalRoleJournal : SecurityPrincipalRole
    {
        public SecurityPrincipalRoleJournal(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        JournalBase fJournal;
        [Persistent("JOURNAL")]
        public JournalBase Journal
        {
            get { return fJournal; }
            set { SetPropertyValue<JournalBase>("Journal", ref fJournal, value); }
        }

        MyEnums.SecurityPrivilege fSecurityPrivilege;
        public MyEnums.SecurityPrivilege SecurityPrivilege
        {
            get { return fSecurityPrivilege; }
            set { SetPropertyValue<MyEnums.SecurityPrivilege>("SecurityPrivilege", ref fSecurityPrivilege, value); }
        }


    }
}
