using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"VEND_ACT_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class Vendor : Account
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.Vendor;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        
        public Vendor(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.Vendor);

            base.AfterConstruction();
        }
        #region Fields

        #endregion

    }
}
