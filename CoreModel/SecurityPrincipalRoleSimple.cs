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
            base.AfterConstruction();
        }
        //Simple table like setup forms 
        TableBase fMasterTable;
        [Persistent(@"MASTER_TABLE")]
        public TableBase MasterTable
        {
            get { return fMasterTable; }
            set { SetPropertyValue<TableBase>("MasterTable", ref fMasterTable, value); }
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
