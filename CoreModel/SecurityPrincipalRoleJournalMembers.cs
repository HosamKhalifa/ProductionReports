using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"SEC_PRINCIPAL_ROLE_JOUR_MEM_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class SecurityPrincipalRoleJournalMembers : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.SecurityPrincipalRoleJournalMembers;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        public SecurityPrincipalRoleJournalMembers(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.SecurityPrincipalRoleJournalMembers);
            base.AfterConstruction();
        }

        SecurityPrincipalRoleJournal fRoleJournal;
        [Persistent(@"ROLE_JOURNAL")]
        [Association(@"ROLE_JOURNAL_MEMBERS_FK")]
        [Indexed(additionalFields:"PrincipalId",Name="ROLE_JOUR_PRINCIPALS_UQ",Unique=true)]
        public SecurityPrincipalRoleJournal RoleJournal
        {
            get { return fRoleJournal; }
            set { SetPropertyValue<SecurityPrincipalRoleJournal>("RoleJournal", ref fRoleJournal, value); }
        }
        SecurityPrincipal fPrincipalId;
        [Persistent(@"PRINCIPAL_ID")]
        public SecurityPrincipal PrincipalId
        {
            get { return fPrincipalId; }
            set { SetPropertyValue<SecurityPrincipal>("PrincipalId", ref fPrincipalId, value); }
        }

        MyEnums.SecurityPrivilegeJournal fSecurityPrivilege;
        [Persistent("SEC_PRIV")]
        public MyEnums.SecurityPrivilegeJournal SecurityPrivilege
        {
            get { return fSecurityPrivilege; }
            set { SetPropertyValue<MyEnums.SecurityPrivilegeJournal>("SecurityPrivilege", ref fSecurityPrivilege, value); }
        }
    }
}
