﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"COUNTRY_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class Country : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.Country;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        public Country(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.Country);
            base.AfterConstruction();
        }

        #region Methods
        public static void BuildTableRows(Session _session)
        {
            var lst = GetCountryList();
            foreach (var item in lst)
            {
                var values = item.Split(';');
                string code = values[0];
                string name = values[1];
                var filter = new BinaryOperator(new OperandProperty("CountryCode"), new OperandValue(code), BinaryOperatorType.Equal);
                var country = _session.FindObject<Country>(filter);
                if(country == null)
                {
                    country = new Country(_session)
                    {
                        CountryCode = code,
                        CountryName = name
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
                "AFG;Afghanistan",
                "ALA;Aland Islands",
                "ALB;Albania",
                "DZA;Algeria",
                "ASM;American Samoa",
                "AND;Andorra",
                "AGO;Angola",
                "AIA;Anguilla",
                "ATA;Antarctica",
                "ATG;Antigua and Barbuda",
                "ARG;Argentina",
                "ARM;Armenia",
                "ABW;Aruba",
                "AUS;Australia",
                "AUT;Austria",
                "AZE;Azerbaijan",
                "BHS;Bahamas",
                "BHR;Bahrain",
                "BGD;Bangladesh",
                "BRB;Barbados",
                "BLR;Belarus",
                "BEL;Belgium",
                "BLZ;Belize",
                "BEN;Benin",
                "BMU;Bermuda",
                "BTN;Bhutan",
                "BOL;Bolivia",
                "BES;Bonaire, Sint Eustatius and Saba",
                "BIH;Bosnia and Herzegovina",
                "BWA;Botswana",
                "BVT;Bouvet Island",
                "BRA;Brazil",
                "IOT;British Indian Ocean Territory",
                "BRN;Brunei Darussalam",
                "BGR;Bulgaria",
                "BFA;Burkina Faso",
                "BDI;Burundi",
                "KHM;Cambodia",
                "CMR;Cameroon",
                "CAN;Canada",
                "CPV;Cape Verde",
                "CYM;Cayman Islands",
                "CAF;Central African Republic",
                "TCD;Chad",
                "CHL;Chile",
                "CHN;China",
                "CXR;Christmas Island",
                "CCK;Cocos (Keeling) Islands",
                "COL;Colombia",
                "COM;Comoros",
                "COG;Congo",
                "COD;Congo, The Democratic Republic of ",
                "COK;Cook Islands",
                "CRI;Costa Rica",
                "CIV;Cote d'Ivoire",
                "HRV;Croatia",
                "CUB;Cuba",
                "CUW;Curaçao",
                "CYP;Cyprus",
                "CZE;Czechia",
                "DNK;Denmark",
                "DJI;Djibouti",
                "DMA;Dominica",
                "DOM;Dominican Republic",
                "ECU;Ecuador",
                "EGY;Egypt",
                "SLV;El Salvador",
                "GNQ;Equatorial Guinea",
                "ERI;Eritrea",
                "EST;Estonia",
                "ETH;Ethiopia",
                "FLK;Falkland Islands (Malvinas)",
                "FRO;Faroe Islands",
                "FJI;Fiji",
                "FIN;Finland",
                "FRA;France",
                "GUF;French Guiana",
                "PYF;French Polynesia",
                "ATF;French Southern Territories",
                "GAB;Gabon",
                "GMB;Gambia",
                "GEO;Georgia",
                "DEU;Germany",
                "GHA;Ghana",
                "GIB;Gibraltar",
                "GRC;Greece",
                "GRL;Greenland",
                "GRD;Grenada",
                "GLP;Guadeloupe",
                "GUM;Guam",
                "GTM;Guatemala",
                "GGY;Guernsey",
                "GIN;Guinea",
                "GNB;Guinea-Bissau",
                "GUY;Guyana",
                "HTI;Haiti",
                "HMD;Heard and Mc Donald Islands",
                "VAT;Holy See (Vatican City State)",
                "HND;Honduras",
                "HKG;Hong Kong",
                "HUN;Hungary",
                "ISL;Iceland",
                "IND;India",
                "IDN;Indonesia",
                "IRN;Iran, Islamic Republic of",
                "IRQ;Iraq",
                "IRL;Ireland",
                "IMN;Isle of Man",
                "ISR;Israel",
                "ITA;Italy",
                "JAM;Jamaica",
                "JPN;Japan",
                "JEY;Jersey",
                "JOR;Jordan",
                "KAZ;Kazakstan",
                "KEN;Kenya",
                "KIR;Kiribati",
                "PRK;Korea, Democratic People's Republic of",
                "KOR;Korea, Republic of",
                "XKX;Kosovo (temporary code)",
                "KWT;Kuwait",
                "KGZ;Kyrgyzstan",
                "LAO;Lao, People's Democratic Republic",
                "LVA;Latvia",
                "LBN;Lebanon",
                "LSO;Lesotho",
                "LBR;Liberia",
                "LBY;Libyan Arab Jamahiriya",
                "LIE;Liechtenstein",
                "LTU;Lithuania",
                "LUX;Luxembourg",
                "MAC;Macao",
                "MKD;Macedonia, The Former Yugoslav Republic Of",
                "MDG;Madagascar",
                "MWI;Malawi",
                "MYS;Malaysia",
                "MDV;Maldives",
                "MLI;Mali",
                "MLT;Malta",
                "MHL;Marshall Islands",
                "MTQ;Martinique",
                "MRT;Mauritania",
                "MUS;Mauritius",
                "MYT;Mayotte",
                "MEX;Mexico",
                "FSM;Micronesia, Federated States of",
                "MDA;Moldova, Republic of",
                "MCO;Monaco",
                "MNG;Mongolia",
                "MNE;Montenegro",
                "MSR;Montserrat",
                "MAR;Morocco",
                "MOZ;Mozambique",
                "MMR;Myanmar",
                "NAM;Namibia",
                "NRU;Nauru",
                "NPL;Nepal",
                "NLD;Netherlands",
                "NCL;New Caledonia",
                "NZL;New Zealand",
                "NIC;Nicaragua",
                "NER;Niger",
                "NGA;Nigeria",
                "NIU;Niue",
                "NFK;Norfolk Island",
                "MNP;Northern Mariana Islands",
                "NOR;Norway",
                "OMN;Oman",
                "PAK;Pakistan",
                "PLW;Palau",
                "PSE;Palestinian Territory, Occupied",
                "PAN;Panama",
                "PNG;Papua New Guinea",
                "PRY;Paraguay",
                "PER;Peru",
                "PHL;Philippines",
                "PCN;Pitcairn",
                "POL;Poland",
                "PRT;Portugal",
                "PRI;Puerto Rico",
                "QAT;Qatar",
                "SRB;Republic of Serbia",
                "REU;Reunion",
                "ROU;Romania",
                "RUS;Russia Federation",
                "RWA;Rwanda",
                "BLM;Saint Barthélemy",
                "SHN;Saint Helena",
                "KNA;Saint Kitts & Nevis",
                "LCA;Saint Lucia",
                "MAF;Saint Martin",
                "SPM;Saint Pierre and Miquelon",
                "VCT;Saint Vincent and the Grenadines",
                "WSM;Samoa",
                "SMR;San Marino",
                "STP;Sao Tome and Principe",
                "SAU;Saudi Arabia",
                "SEN;Senegal",
                "SYC;Seychelles",
                "SLE;Sierra Leone",
                "SGP;Singapore",
                "SXM;Sint Maarten",
                "SVK;Slovakia",
                "SVN;Slovenia",
                "SLB;Solomon Islands",
                "SOM;Somalia",
                "ZAF;South Africa",
                "SGS;South Georgia & The South Sandwich Islands",
                "SSD;South Sudan",
                "ESP;Spain",
                "LKA;Sri Lanka",
                "SDN;Sudan",
                "SUR;Suriname",
                "SJM;Svalbard and Jan Mayen",
                "SWZ;Swaziland",
                "SWE;Sweden",
                "CHE;Switzerland",
                "SYR;Syrian Arab Republic",
                "TWN;Taiwan, Province of China",
                "TJK;Tajikistan",
                "TZA;Tanzania, United Republic of",
                "THA;Thailand",
                "TLS;Timor-Leste",
                "TGO;Togo",
                "TKL;Tokelau",
                "TON;Tonga",
                "TTO;Trinidad and Tobago",
                "TUN;Tunisia",
                "TUR;Turkey",
                "XTX;Turkish Rep N Cyprus (temporary code)",
                "TKM;Turkmenistan",
                "TCA;Turks and Caicos Islands",
                "TUV;Tuvalu",
                "UGA;Uganda",
                "UKR;Ukraine",
                "ARE;United Arab Emirates",
                "GBR;United Kingdom",
                "USA;United States",
                "UMI;United States Minor Outlying Islands",
                "URY;Uruguay",
                "UZB;Uzbekistan",
                "VUT;Vanuatu",
                "VEN;Venezuela",
                "VNM;Vietnam",
                "VGB;Virgin Islands, British",
                "VIR;Virgin Islands, U.S.",
                "WLF;Wallis and Futuna",
                "ESH;Western Sahara",
                "YEM;Yemen",
                "ZMB;Zambia",
                "ZWE;Zimbabwe"

            };
            return lst;
        }
        #endregion

        #region Fields
        string fCountryCode;
        [Persistent(@"COUNTRY_CODE"),Size(3)]
        [Indexed(Name ="COUNTRY_CODE_UQ",Unique =true)]
        public string CountryCode
        {
            get { return fCountryCode; }
            set { SetPropertyValue<string>("CountryCode", ref fCountryCode, value); }
        }
        string fCountryName;
        [Persistent(@"COUNTRY_NAME"),Size(100)]
        public string CountryName
        {
            get { return fCountryName; }
            set { SetPropertyValue<string>("CountryName", ref fCountryName, value); }
        }

        #endregion

        #region Association
       
        [Association(@"COUNTRY_PROVINCE_FK")]
        public XPCollection<Province> Provinces { get { return GetCollection<Province>("Provinces"); } }
        #endregion

    }
}
