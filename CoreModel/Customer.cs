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
        public static string TABLE_NAME = @"CUST_ACT_TB";
        public Customer(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = Session.FindObject<TableBase>(CriteriaOperator.Parse(" [TABLE_NAME] = ? ", TABLE_NAME));
            
            base.AfterConstruction();
        }
        #region Fields
        
        #endregion

    }
}
