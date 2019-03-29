using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"TAX_GROUP_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class TaxGroup : Line
    {
        public static string TABLE_NAME = "TAX_GROUP_TB";
        public TaxGroup(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.TaxGroup);
            base.AfterConstruction();
        }

        [Association(@"TaxGroup-Address")]
        public XPCollection<AddressBook> Addresses { get { return GetCollection<AddressBook>("Addresses"); } }

    }
}
