using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"SEC_PRINCIPAL_ROLE_SIM_MEM_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class SecurityPrincipalRoleSimpleMembers : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.SecurityPrincipalRoleSimpleMembers;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        public SecurityPrincipalRoleSimpleMembers(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.SecurityPrincipalRoleSimpleMembers);
            base.AfterConstruction();
        }
        SecurityPrincipalRoleSimple fRoleSimple;
        [Persistent(@"ROLE_SIMPLE")]
        [Indexed(additionalFields: "PrincipalId", Name = "ROLE_SIMPLE_PRINCIPALS_UQ", Unique = true)]
        public SecurityPrincipalRoleSimple RoleSimple
        {
            get { return fRoleSimple; }
            set { SetPropertyValue<SecurityPrincipalRoleSimple>("RoleSimple", ref fRoleSimple, value); }
        }
        SecurityPrincipal fPrincipalId;
        [Persistent(@"PRINCIPAL_ID")]
        public SecurityPrincipal PrincipalId
        {
            get { return fPrincipalId; }
            set { SetPropertyValue<SecurityPrincipal>("PrincipalId", ref fPrincipalId, value); }
        }
        MyEnums.SecurityAccessEnum fSecurityPrivilege;
        [Persistent("SEC_PRIV")]
        public MyEnums.SecurityAccessEnum SecurityPrivilege
        {
            get { return fSecurityPrivilege; }
            set { SetPropertyValue<MyEnums.SecurityAccessEnum>("SecurityPrivilege", ref fSecurityPrivilege, value); }
        }
    }
}
