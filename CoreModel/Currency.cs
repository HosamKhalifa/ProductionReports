using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"CURRENCY_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class Currency : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.Currency;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        //public static string TABLE_NAME = @"CURRENCY_TB";
        public Currency(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.Currency);
            base.AfterConstruction();
        }
        #region Fields

        string fIsoCode;
        [Persistent(@"ISO_CODE"),Size(4)]
        [Indexed(Name ="ISO_CODE_UQ",Unique =true)]
        public string IsoCode
        {
            get { return fIsoCode; }
            set { SetPropertyValue<string>("IsoCode", ref fIsoCode, value); }
        }
        string fSymbol;
        [Persistent(@"SYMBOL"), Size(3)]
        public string Symbol
        {
            get { return fSymbol; }
            set { SetPropertyValue<string>("Symbol", ref fSymbol, value); }
        }

        #endregion

        #region Methods
        public static void BuildTableRows(Session _session)
        {
            var lst = GetCountryList();
            foreach (var item in lst)
            {
                var filter = new BinaryOperator(new OperandProperty("IsoCode"), new OperandValue(item), BinaryOperatorType.Equal);
                var country = _session.FindObject<Currency>(filter);
                if (country == null)
                {
                    country = new Currency(_session)
                    {
                        IsoCode = item,
                        Symbol = ""
                    };
                    country.Save();
                }

            }
            _session.CommitTransaction();
        }
        static List<string> GetCountryList()
        {
            var lst = new List<string>()
            {
                "AFN",
                "AED",
                "ALL",
                "AMD",
                "ANG",
                "AOA",
                "ARS",
                "AUD",
                "AWG",
                "AZN",
                "BAM",
                "BBD",
                "BDT",
                "BGN",
                "BHD",
                "BIF",
                "BMD",
                "BND",
                "BOB",
                "BOV",
                "BRL",
                "BSD",
                "BTN",
                "BWP",
                "BYN",
                "BZD",
                "CAD",
                "CDF",
                "CHE",
                "CHF",
                "CHW",
                "CLF",
                "CLP",
                "CNY",
                "COP",
                "COU",
                "CRC",
                "CUC",
                "CUP",
                "CVE",
                "CZK",
                "DJF",
                "DKK",
                "DOP",
                "DZD",
                "EGP",
                "ERN",
                "ETB",
                "EUR",
                "FJD",
                "FKP",
                "GBP",
                "GEL",
                "GHS",
                "GIP",
                "GMD",
                "GNF",
                "GTQ",
                "GYD",
                "HKD",
                "HNL",
                "HRK",
                "HTG",
                "HUF",
                "IDR",
                "ILS",
                "INR",
                "IQD",
                "IRR",
                "ISK",
                "JMD",
                "JOD",
                "JPY",
                "KES",
                "KGS",
                "KHR",
                "KMF",
                "KPW",
                "KRW",
                "KWD",
                "KYD",
                "KZT",
                "LAK",
                "LBP",
                "LKR",
                "LRD",
                "LSL",
                "LYD",
                "MAD",
                "MDL",
                "MGA",
                "MKD",
                "MMK",
                "MNT",
                "MOP",
                "MRU",
                "MUR",
                "MVR",
                "MWK",
                "MXN",
                "MXV",
                "MYR",
                "MZN",
                "NAD",
                "NGN",
                "NIO",
                "NOK",
                "NPR",
                "NZD",
                "OMR",
                "PAB",
                "PEN",
                "PGK",
                "PHP",
                "PKR",
                "PLN",
                "PYG",
                "QAR",
                "RON",
                "RSD",
                "RUB",
                "RWF",
                "SAR",
                "SBD",
                "SCR",
                "SDG",
                "SEK",
                "SGD",
                "SHP",
                "SLL",
                "SOS",
                "SRD",
                "SSP",
                "STN",
                "SVC",
                "SYP",
                "SZL",
                "THB",
                "TJS",
                "TMT",
                "TND",
                "TOP",
                "TRY",
                "TTD",
                "TWD",
                "TZS",
                "UAH",
                "UGX",
                "USD",
                "USN",
                "UYI",
                "UYU",
                "UYW",
                "UZS",
                "VES",
                "VND",
                "VUV",
                "WST",
                "XAF",
                "XAG",
                "XAU",
                "XBA",
                "XBB",
                "XBC",
                "XBD",
                "XCD",
                "XDR",
                "XOF",
                "XPD",
                "XPF",
                "XPT",
                "XSU",
                "XTS",
                "XUA",
                "XXX",
                "YER",
                "ZAR",
                "ZMW",
                "ZWL"

            };
            return lst;
        }

        #endregion

    }
}
