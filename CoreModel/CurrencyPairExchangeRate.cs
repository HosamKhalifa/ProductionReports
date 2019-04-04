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
            set { SetPropertyValue<CurrencyPair>("CurrencyPair", ref fCurrencyPair, value); }
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

    }
}
