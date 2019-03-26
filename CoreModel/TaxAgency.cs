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
        public static string TABLE_NAME = @"TAX_AGENCY_TB";
        public TaxAgency(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = Session.FindObject<TableBase>(CriteriaOperator.Parse(" [TABLE_NAME] = ? ", TABLE_NAME));
            base.AfterConstruction();
        }

        string fTaxAgencyName;
        public string TaxAgencyName
        {
            get { return fTaxAgencyName; }
            set { SetPropertyValue<string>("TaxAgencyName",ref fTaxAgencyName, value); }
        }

        [Association(@"TaxAgency-Address")]
        public XPCollection<Address> Addresses { get { return GetCollection<Address>("Addresses"); } }
    }
}
