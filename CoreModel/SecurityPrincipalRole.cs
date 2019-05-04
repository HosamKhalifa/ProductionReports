using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"SEC_PRINCIPAL_ROLE_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class SecurityPrincipalRole : SecurityPrincipal
    {
        public SecurityPrincipalRole(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }




    }
}
