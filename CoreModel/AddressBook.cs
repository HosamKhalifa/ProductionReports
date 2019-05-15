using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    [Persistent(@"ADDR_BOOK_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class AddressBook : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.AddressBook;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        //public static string TABLE_NAME = "ADDR_BOOK_TB";
        public AddressBook(Session session) : base(session) { }
      
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.AddressBook);

            base.AfterConstruction();
        }

        #region Fields
        int fRowNumber;
        [Persistent(@"ROW_NUM")]
        public int RowNumber
        {
            get { return fRowNumber; }
            set { SetPropertyValue<int>("RowNumber", ref fRowNumber, value); }
        }
        Account fAccount;
        [Persistent(@"ACT_ID")]
        [Association(@"Account-Addresses")]
        public Account Account
        {
            get { return fAccount; }
            set { SetPropertyValue<Account>("Account", ref fAccount, value); }
        }
        bool fIsPrimary;
        [Persistent(@"IS_PRIMARY")]
        public bool IsPrimary
        {
            get { return fIsPrimary; }
            set { SetPropertyValue<bool>("IsPrimary", ref fIsPrimary, value); }
        }

        string fAddressDetails;
        [Persistent(@"ADDRESS_DETAILS"),Size(300)]
        public string AddressDetails
        {
            get { return fAddressDetails; }
            set { SetPropertyValue<string>("AddressDetails", ref fAddressDetails, value); }
        }
        string fContact;
        [Persistent(@"CONTACT"), Size(150)]
        public string Contact
        {
            get { return fContact; }
            set { SetPropertyValue<string>("Contact", ref fContact, value); }
        }
        string fReportHint;
        [Persistent(@"RPT_HINT")]
        public string ReportHint
        {
            get { return fReportHint; }
            set { SetPropertyValue<string>("ReportHint", ref fReportHint, value); }
        }
        string fTelephone;
        [Persistent(@"TEL"), Size(30)]
        public string Telephone
        {
            get { return fTelephone; }
            set { SetPropertyValue<string>("Telephone", ref fTelephone, value); }
        }
        string fMobile;
        [Persistent(@"MOB"), Size(30)]
        public string Mobile
        {
            get { return fMobile; }
            set { SetPropertyValue<string>("Mobile", ref fMobile, value); }
        }
        string fFax;
        [Persistent(@"FAX"), Size(30)]
        public string Fax
        {
            get { return fFax; }
            set { SetPropertyValue<string>("Fax", ref fFax, value); }
        }
        string fEmail;
        [Persistent(@"EMAIL"), Size(100)]
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>("Email", ref fEmail, value); }
        }
        string fCountry;
        [Persistent(@"COUNTRY"),Size(10)]
        public string Country
        {
            get { return fCountry; }
            set { SetPropertyValue<string>("Country", ref fCountry, value); }
        }
        string fCity;
        [Persistent(@"CITY"), Size(10)]
        public string City
        {
            get { return fCity; }
            set
            {
                SetPropertyValue<string>("City", ref fCity, value);
                if(!IsLoading && fCity != null)
                {
                    var city = Session.FindObject<City>(new BinaryOperator("CityCode", fCity, BinaryOperatorType.Equal));
                    if(city != null)
                    {
                        Country = city.Province.ProvinceCountry.CountryCode;
                    }
                }
            }

        }
        string fTaxFileNumber;
        [Persistent(@"TAX_FILE_NUM"), Size(20)]
        public string TaxFileNumber
        {
            get { return fTaxFileNumber; }
            set { SetPropertyValue<string>("TaxFileNumber", ref fTaxFileNumber, value); }
        }
        string fTaxCardNumber;
        [Persistent(@"TAX_CARD_NUM"), Size(20)]
        public string TaxCardNumber
        {
            get { return fTaxCardNumber; }
            set { SetPropertyValue<string>("TaxCardNumber", ref fTaxCardNumber, value); }
        }
        string fCommercialRegistry;
        [Persistent(@"COMM_REGISTRY"), Size(20)]
        public string CommercialRegistry
        {
            get { return fCommercialRegistry; }
            set { SetPropertyValue<string>("CommercialRegistry", ref fCommercialRegistry, value); }
        }
        TaxAgency fTaxAgency;
        [Persistent(@"TAX_AGENCY")]
        [Association(@"TaxAgency-Address")]
        public TaxAgency TaxAgency
        {
            get { return fTaxAgency; }
            set { SetPropertyValue<TaxAgency>("TaxAgency", ref fTaxAgency, value); }
        }

        TaxGroup fTaxGroup;
        [Persistent(@"TAX_GROUP")]
        [Association(@"TaxGroup-Address")]
        public TaxGroup TaxGroup
        {
            get { return fTaxGroup; }
            set { SetPropertyValue<TaxGroup>("TaxGroup", ref fTaxGroup, value); }
        }

        #endregion

    }
}
