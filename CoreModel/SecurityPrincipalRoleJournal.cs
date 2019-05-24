using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class SecurityPrincipalRoleJournal : SecurityPrincipalRole
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.SecurityPrincipalRoleJournal;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        public SecurityPrincipalRoleJournal(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        JournalBase fJournal;
        [Persistent("JOURNAL")]
        [Indexed(Name ="ROLE_JOURNAL_PRIV_UQ",Unique =true)]
        public JournalBase Journal
        {
            get { return fJournal; }
            set { SetPropertyValue<JournalBase>("Journal", ref fJournal, value); }
        }

        


    }
}
