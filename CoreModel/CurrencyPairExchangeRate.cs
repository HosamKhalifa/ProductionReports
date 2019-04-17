using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace CoreModel
{
    [Persistent(@"CURRENCY_PAIR_EXCHANGE_RATE_TB")]
    public class CurrencyPairExchangeRate : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.CurrencyPairExchangeRate;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        public CurrencyPairExchangeRate(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.CurrencyPairExchangeRate);
            base.AfterConstruction();
            ValidFrom = DateTime.Today.Date;
            ValidTo = ValidFrom.AddMonths(1);
        }
        CurrencyPair fCurrencyPair;
        [Persistent(@"CURRENCY_PAIR")]
        [Association(@"CURR_PAIR_EXCHANGE_RATE_FK")]
        public CurrencyPair CurrencyPair
        {
            get { return fCurrencyPair; }
            set
            {
                SetPropertyValue<CurrencyPair>("CurrencyPair", ref fCurrencyPair, value);
                WriteComputation();
            }
        }

        DateTime fValidFrom;
        [Persistent(@"VALID_FROM")]
        public DateTime ValidFrom
        {
            get { return fValidFrom; }
            set { SetPropertyValue<DateTime>("ValidFrom", ref fValidFrom, value.Date); }
        }
        DateTime fValidTo;
        [Persistent(@"VALID_TO")]
        public DateTime ValidTo
        {
            get { return fValidTo; }
            set { SetPropertyValue<DateTime>("ValidTo", ref fValidTo, value.Date); }
        }

        decimal fExchangeRate;
        [Persistent(@"EXCHANGE_RATE")]
        public decimal ExchangeRate
        {
            get { return fExchangeRate; }
            set { SetPropertyValue<decimal>("ExchangeRate", ref fExchangeRate, value); }
        }


        #region Computed
        private void WriteComputation()
        {
            CurrencyFromToKey = CurrencyPair != null? CurrencyPair.FromToKey:"";
        }
        string fCurrencyFromToKey;
        [NonPersistent,Size(10)]
        public string CurrencyFromToKey
        {
            get { return fCurrencyFromToKey; }
            private set { SetPropertyValue<string>("CurrencyFromToKey", ref fCurrencyFromToKey, value); }
        }
        #endregion

    }
}
