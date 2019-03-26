using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace CoreModel
{
    [Persistent(@"DOC_LINE_TYPE_INVENTORY")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class DocumentLineTypeInventory : DocumentLineTypeBase
    {
        public static string TABLE_NAME = @"DOC_LINE_TYPE_INVENTORY";
        public DocumentLineTypeInventory(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            TableId = Session.FindObject<TableBase>(CriteriaOperator.Parse(" [TABLE_NAME] = ? ", TABLE_NAME));
            base.AfterConstruction();
        }

        #region Fields
        MyEnums.InventoryDirection fInventoryDirection;
        [Persistent(@"INVENTORY_DIRECTION")]
        public MyEnums.InventoryDirection InventoryDirection
        {
            get { return fInventoryDirection; }
            set { SetPropertyValue<MyEnums.InventoryDirection>("InventoryDirection", ref fInventoryDirection, value); }
        }
        bool fIsAutoPrice;
        [Persistent(@"IS_AUTO_PRICE")]
        public bool IsAutoPrice
        {
            get { return fIsAutoPrice; }
            set { SetPropertyValue<bool>("IsAutoPrice", ref fIsAutoPrice, value); }
        }
        bool fIsAllowZeroQuantity;
        [Persistent(@"IS_ALLOW_ZERO_QTY")]
        public bool IsAllowZeroQuantity
        {
            get { return fIsAllowZeroQuantity; }
            set { SetPropertyValue<bool>("IsAllowZeroQuantity", ref fIsAllowZeroQuantity, value); }
        }

        bool fIsAllowZeroValue;
        [Persistent(@"IS_ALLOW_ZERO_VALUE")]
        public bool IsAllowZeroValue
        {
            get { return fIsAllowZeroValue; }
            set { SetPropertyValue<bool>("IsAllowZeroValue", ref fIsAllowZeroValue, value); }
        }
        #endregion

    }
}
