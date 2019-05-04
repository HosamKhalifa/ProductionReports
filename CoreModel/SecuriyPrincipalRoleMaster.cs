using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class SecuriyPrincipalRoleMaster : SecurityPrincipalRole
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.SecurityPrincipalRoleMaster;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        public SecuriyPrincipalRoleMaster(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        TableBase fMasterTable;
        [Persistent(@"MASTER_TABLE")]
        public TableBase MasterTable
        {
            get { return fMasterTable; }
            set { SetPropertyValue<TableBase>("MasterTable", ref fMasterTable, value); }
        }
        MyEnums.DefinitionType fDefinitionType;
        [Persistent("DEFINITION_TYPE")]
        public MyEnums.DefinitionType DefinitionType
        {
            get { return fDefinitionType; }
            set { SetPropertyValue("DefinitionType", ref fDefinitionType, value); }
        }

        Line fLineRef;
        [Persistent("LINE_REF")]
        public Line LineRef
        {
            get { return fLineRef; }
            set { SetPropertyValue<Line>("LineRef", ref fLineRef, value); }
        }
        MyEnums.SecurityPrivilegeMaster fSecurityPrivilege;
        [Persistent("SEC_PRIV")]
        public MyEnums.SecurityPrivilegeMaster SecurityPrivilege
        {
            get { return fSecurityPrivilege; }
            set { SetPropertyValue<MyEnums.SecurityPrivilegeMaster>("SecurityPrivilege", ref fSecurityPrivilege, value); }
        }
    }
}
