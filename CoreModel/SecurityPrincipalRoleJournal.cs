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
        public static TableBase.TableEnum TableName = TableBase.TableEnum.SecurityPrincipalRoleJournal;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
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

        MyEnums.SecurityPrivilegeJournal fSecurityPrivilege;
        [Persistent("SEC_PRIV") ]
        public MyEnums.SecurityPrivilegeJournal SecurityPrivilege
        {
            get { return fSecurityPrivilege; }
            set { SetPropertyValue<MyEnums.SecurityPrivilegeJournal>("SecurityPrivilege", ref fSecurityPrivilege, value); }
        }


    }
}
