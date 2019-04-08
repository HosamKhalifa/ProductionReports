using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using CoreLib.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"CURRENCY_PAIR_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class CurrencyPair : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.CurrencyPair;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        public CurrencyPair(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();   
        }

        string fFromCurrencyCode;
        [Persistent(@"FROM_CURR_CODE"), Size(4)]
        public string FromCurrencyCode
        {
            get { return fFromCurrencyCode; }
            set
            {
                SetPropertyValue<string>("FromCurrencyCode", ref fFromCurrencyCode, value);
                WriteFromToKey();
            }
        }


        string fToCurrencyCode;
        [Persistent(@"TO_CURR_CODE"), Size(4)]
        public string ToCurrencyCode
        {
            get { return fToCurrencyCode; }
            set
            {
                SetPropertyValue<string>("ToCurrencyCode", ref fToCurrencyCode, value);
                WriteFromToKey();
            }
        }

        string fFromToKey;
        [Persistent(@"FROM_TO_KEY"),Size(8)]
        
        public string FromToKey
        {
            get { return fFromToKey; }
            private set { SetPropertyValue<string>("FromToKey", ref fFromToKey, value); }
        }
        private void WriteFromToKey()
        {
            string ret = $"{FromCurrencyCode ?? ""}=>{ToCurrencyCode ?? ""}";
            FromToKey = ret;
        }
        #region Associations
        [Association(@"CURR_PAIR_EXCHANGE_RATE_FK")]
        public XPCollection<CurrencyPairExchangeRate> ExchangeRates { get { return GetCollection<CurrencyPairExchangeRate>("ExchangeRates"); } }
        #endregion
        



    }
}
