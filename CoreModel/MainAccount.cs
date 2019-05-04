using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using CoreLib.SharedExt;
namespace CoreModel
{
    [Persistent(@"MAIN_ACCOUNT_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class MainAccount : Account
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.MainAccount;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        //public static string TABLE_NAME = @"MAIN_ACCOUNT_TB";
        public MainAccount(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.MainAccount);
            MainAccountClass = MyEnums.MainAccountClass.Assets;
            Active = true;
            BalanceControl = MyEnums.BalanceControl.None;
            DisableManualEntry = false;
            base.AfterConstruction();
        }
        #region Methods
        protected override bool Validate()
        {
            bool ret = true;
            ret = ret && MainAccountType != null;
            ret = ret && EffectiveFrom != null;
            ret = ret && LedgerChartOfAccounts != null;
            ret = ret && DisplayNumber.IsNotNull();
            ret = ret && Name.IsNotNull();

            return base.Validate() && ret;
        }
        void InitAccountClass(MyEnums.MainAccountClass _mainActClass)
        {
            
        }
        #endregion
        #region Fields
        int fDepth;
        [Persistent(@"DEPTH")]
        public int Depth
        {
            get { return fDepth; }
            set { SetPropertyValueExt<int>("Depth", ref fDepth, value); }
        }

        MainAccountType fMainAccountType;
        [Persistent(@"MAIN_ACCOUNT_TYPE")]
        public MainAccountType MainAccountType
        {
            get { return fMainAccountType; }
            set { SetPropertyValueExt<MainAccountType>("MainAccountType", ref fMainAccountType, value); }
        }
        DateTime fEffectiveFrom;
        [Persistent(@"EFFECTIVE_FROM")]
        public DateTime EffectiveFrom
        {
            get { return fEffectiveFrom; }
            set { SetPropertyValueExt<DateTime>("EffectiveFrom", ref fEffectiveFrom, value); }
        }
        LedgerChartOfAccounts fLedgerChartOfAccounts;
        [Persistent(@"LEDGER_COA")]
        [Association("LEDGER_COA_MAIN_ACCOUNTS_FK")]
        public LedgerChartOfAccounts LedgerChartOfAccounts
        {
            get { return fLedgerChartOfAccounts; }
            set { SetPropertyValue<LedgerChartOfAccounts>("LedgerChartOfAccounts", ref fLedgerChartOfAccounts, value); }
        }

        MyEnums.BalanceControl fBalanceControl;
        [Persistent(@"BALANCE_CONTROL")]
        public MyEnums.BalanceControl BalanceControl
        {
            get { return fBalanceControl; }
            set { SetPropertyValueExt<MyEnums.BalanceControl>("BalanceControl", ref fBalanceControl, value); }
        }
        MyEnums.AccountClosingType fAccountClosingType;
        [Persistent(@"ACCOUNT_CLOSING_TYPE")]
        public MyEnums.AccountClosingType AccountClosingType
        {
            get { return fAccountClosingType; }
            set { SetPropertyValueExt<MyEnums.AccountClosingType>("AccountClosingType", ref fAccountClosingType, value); }
        }
        bool fDisableManualEntry;
        [Persistent(@"DISABLE_MANUAL_ENTRY")]
        public bool DisableManualEntry
        {
            get { return fDisableManualEntry; }
            set { SetPropertyValueExt<bool>("DisableManualEntry", ref fDisableManualEntry, value); }
        }
        MyEnums.MainAccountClass fMainAccountClass;
        [Persistent(@"MAIN_ACCOUNT_CLASS")]
        public MyEnums.MainAccountClass MainAccountClass
        {
            get { return fMainAccountClass; }
            set { SetPropertyValueExt<MyEnums.MainAccountClass>("MainAccountClass", ref fMainAccountClass, value); }
        }
        MyEnums.AccountType fDetailsType;
        [Persistent(@"MAIN_ACCOUNT_DETAIL_TYPE")]
        public MyEnums.AccountType DetailsType
        {
            get { return fDetailsType; }
            set { SetPropertyValueExt<MyEnums.AccountType>("DetailsType", ref fDetailsType, value); }
        }


        #endregion

        #region Associations
        [Association(@"DOC_LINE_MAIN_ACCOUNT_FK")]
        public XPCollection<DocumentLineBase> DocumentLines { get{ return GetCollection<DocumentLineBase>("DocumentLines"); } }
        #endregion

    }
}
