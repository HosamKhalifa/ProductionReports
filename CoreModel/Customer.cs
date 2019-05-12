using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"CUST_ACT_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class Customer: Account
    {
        public static TableBase.TableEnum TableName = TableBase.TableEnum.Customer;
        public static MyEnums.TableType TableType = MyEnums.TableType.Master;
        //public static string TABLE_NAME = @"CUST_ACT_TB";
        public Customer(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = TableBase.GetTable(Session, TableBase.TableEnum.Customer);
           
            base.AfterConstruction();
        }
        #region Fields
        
        #endregion

    }
}
