using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class SecurityPrincipalRoleSimple : SecurityPrincipalRole
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.SecurityPrincipalRoleSimple;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        public SecurityPrincipalRoleSimple(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            this.RoleType = MyEnums.SecurityRoleType.Simple;
            base.AfterConstruction();
        }
        //Simple table like setup forms 
        TableBase fMasterTable;
        [Persistent(@"MASTER_TABLE")]
        [Indexed("RoleType", Name ="ROLE_SIMPLE_TABLE_PRIV_UQ", Unique = true)]
        public TableBase MasterTable
        {
            get { return fMasterTable; }
            set { SetPropertyValue<TableBase>("MasterTable", ref fMasterTable, value); }
        }
      


    }
}
