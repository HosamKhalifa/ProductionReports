using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"LEDGER_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class Ledger : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.Ledger;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        public Ledger(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        string fLederName;
        [Persistent(@"LEDGER_NAME")]
        public string LedgerName
        {
            get { return fLederName; }
            set { SetPropertyValue<string>("LedgerName", ref fLederName, value); }
        }
        Currency fAccountingCurrency;
        [Persistent(@"ACCOUNTING_CURR")]
        public Currency AccountingCurrency
        {
            get { return fAccountingCurrency; }
            set { SetPropertyValue<Currency>("AccountingCurrency", ref fAccountingCurrency, value); }
        }

        FiscalCalendar fFiscalCalendar;
        [Persistent(@"FISCAL_CALENDER")]
        public FiscalCalendar FiscalCalendar
        {
            get { return fFiscalCalendar; }
            set { SetPropertyValue<FiscalCalendar>("FiscalCalendar", ref fFiscalCalendar, value); }
        }
        LedgerChartOfAccounts fLedgerChartOfAccounts;
        [Persistent(@"LEDGER_COA")]
        [Association(@"LEDGER_COA_FK")]
        public LedgerChartOfAccounts LedgerChartOfAccounts
        {
            get { return fLedgerChartOfAccounts; }
            set { SetPropertyValue<LedgerChartOfAccounts>("LedgerChartOfAccounts", ref fLedgerChartOfAccounts, value); }
        }

    }
}
