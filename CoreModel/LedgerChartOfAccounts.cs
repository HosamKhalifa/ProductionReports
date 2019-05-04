using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"LEDGER_COA_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class LedgerChartOfAccounts : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.LedgerChartOfAccounts;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        public LedgerChartOfAccounts(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.LedgerChartOfAccounts);
            base.AfterConstruction();
        }
        string fChartOfAccountsName;
        [Persistent(@"COA_NAME"),Size(10)]
        public string ChartOfAccountsName
        {
            get { return fChartOfAccountsName; }
            set { SetPropertyValue<string>("ChartOfAccountsName", ref fChartOfAccountsName, value); }
        }
        string fChartOfAccountsDescription;
        [Persistent(@"COA_DESC"),Size(150)]
        public string ChartOfAccountsDescription
        {
            get { return fChartOfAccountsDescription; }
            set { SetPropertyValue<string>("ChartOfAccountsDescription", ref fChartOfAccountsDescription, value); }
        }
        #region Association
        [Association(@"LEDGER_COA_FK")]
        public XPCollection<Ledger> Ledgers { get { return GetCollection<Ledger>("Ledgers"); }  }
        [Association("LEDGER_COA_MAIN_ACCOUNTS_FK")]
        public XPCollection<MainAccount> MainAccounts { get { return GetCollection<MainAccount>("MainAccounts"); } }
        #endregion
    }
}
