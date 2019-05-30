using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class SecurityPrincipalRoleMaster : SecurityPrincipalRole
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.SecurityPrincipalRoleMaster;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        public SecurityPrincipalRoleMaster(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            this.RoleType = MyEnums.SecurityRoleType.Master;
            base.AfterConstruction();
        }
        TableBase fMasterTable;
        [Persistent(@"MASTER_TABLE")]
        [Indexed("RoleType", Name ="ROLE_MASTER_TABLE_PRIV_UQ",Unique =true)]
        public TableBase MasterTable
        {
            get { return fMasterTable; }
            set { SetPropertyValue<TableBase>("MasterTable", ref fMasterTable, value); }
        }
     
    }
}
