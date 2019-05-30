using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"SEC_PRINCIPAL_ROLE_OU_MEM_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class SecurityPrincipalRoleOUMembers : Line
    {
        public SecurityPrincipalRoleOUMembers(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {

            base.AfterConstruction();
        }

        SecurityPrincipalRoleOU fRoleOU;
        [Persistent(@"ROLE_OU")]
        [Indexed("User",Name ="ROLE_OU_USER_MEMBER_UQ",Unique =true)]
        [Association(@"SEC_PRINCIPAL_ROLE_OU_MEMBERS_FK")]
        public SecurityPrincipalRoleOU RoleOU
        {
            get { return fRoleOU; }
            set { SetPropertyValue<SecurityPrincipalRoleOU>("RoleOU", ref fRoleOU, value); }
        }
        SecurityPrincipalUser fUser;
        [Persistent(@"USER")]
        [Association(@"SEC_PRINCIPAL_USER_MEMBERS_FK")]
        public SecurityPrincipalUser User
        {
            get { return fUser; }
            set { SetPropertyValue<SecurityPrincipalUser>("User", ref fUser, value); }
        }

    }
}
