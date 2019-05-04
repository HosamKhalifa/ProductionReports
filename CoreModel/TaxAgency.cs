using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"TAX_AGENCY_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class TaxAgency : Line
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.TaxAgency;
        public static MyEnums.TableType TableType = MyEnums.TableType.Setup;
        //public static string TABLE_NAME = @"TAX_AGENCY_TB";
        public TaxAgency(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.TaxAgency);
            base.AfterConstruction();
        }

        string fTaxAgencyName;
        public string TaxAgencyName
        {
            get { return fTaxAgencyName; }
            set { SetPropertyValue<string>("TaxAgencyName",ref fTaxAgencyName, value); }
        }

        [Association(@"TaxAgency-Address")]
        public XPCollection<AddressBook> Addresses { get { return GetCollection<AddressBook>("Addresses"); } }
    }
}
