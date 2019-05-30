using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class SecurityPrincipalRoleOU : SecurityPrincipalRole
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.SecurityPrincipalRoleOU;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        public SecurityPrincipalRoleOU(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            this.RoleType = MyEnums.SecurityRoleType.OU;
            base.AfterConstruction();
        }

        [Association(@"SEC_PRINCIPAL_ROLE_OU_MEMBERS_FK")]
        public XPCollection<SecurityPrincipalRoleOUMembers> Members { get { return GetCollection<SecurityPrincipalRoleOUMembers>("Members"); } }

    }
}
