using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

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
            this.RoleType = MyEnums.SecurityRoleType.Journal;
            base.AfterConstruction();
        }

        #region Methods
        public static SecurityPrincipalRoleJournal FindOrCreateJournal(Session _uOW,JournalBase _journalBase)
        {
            //Search by journalcode because RoleJournal created using journal base code
            SecurityPrincipalRoleJournal jour = _uOW.GetObjectByKey<SecurityPrincipalRoleJournal>(_journalBase.JournalCode);
            if(jour == null)
            {
                //Try using journal system Line id
                jour = _uOW.FindObject<SecurityPrincipalRoleJournal>(new BinaryOperator( new OperandProperty("Journal"),new OperandValue(_journalBase),BinaryOperatorType.Equal));
            }
            if(jour == null)
            {
                jour = new SecurityPrincipalRoleJournal(_uOW)
                {
                    RoleType=MyEnums.SecurityRoleType.Journal,
                    PrincipalId=_journalBase.JournalCode,
                    Journal=_journalBase,
                    UserName= _journalBase.JournalName
                };
                jour.Save();
                _uOW.CommitTransaction();
            }

            return jour;

        }
        #endregion 
        #region Fields

        JournalBase fJournal;
        [Persistent("JOURNAL")]
        [Indexed("RoleType", Name ="ROLE_JOURNAL_PRIV_UQ",Unique =true)]
        public JournalBase Journal
        {
            get { return fJournal; }
            set { SetPropertyValue<JournalBase>("Journal", ref fJournal, value); }
        }

        #endregion
        


    }
}
