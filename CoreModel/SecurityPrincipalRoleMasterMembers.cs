using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"SEC_PRINCIPAL_ROLE_MAST_MEM_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class SecurityPrincipalRoleMasterMembers : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.SecurityPrincipalRoleMasterMembers;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        public SecurityPrincipalRoleMasterMembers(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.SecurityPrincipalRoleMasterMembers);
            base.AfterConstruction();
        }
        SecurityPrincipalRoleMaster fRoleMaster;
        [Persistent(@"ROLE_MASTER")]
        public SecurityPrincipalRoleMaster RoleMaster
        {
            get { return fRoleMaster; }
            set { SetPropertyValue<SecurityPrincipalRoleMaster>("RoleMaster", ref fRoleMaster, value); }
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
        SecurityPrincipal fPrincipalId;
        [Persistent(@"PRINCIPAL_ID")]
        public SecurityPrincipal PrincipalId
        {
            get { return fPrincipalId; }
            set { SetPropertyValue<SecurityPrincipal>("PrincipalId", ref fPrincipalId, value); }
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
