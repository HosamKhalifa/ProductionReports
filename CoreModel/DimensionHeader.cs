using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    [Persistent(@"DIMENSION_HEADER")]
    public class DimensionHeader : XPLiteObject
    {
        public DimensionHeader(Session session) : base(session)
        {
        }
        public DimensionHeader(Session session,Account _account):base(session)
        {
            DimDisplayNumber = _account.DisplayNumber;
            DimSearchName = _account.Name;
            DimAccountBase = _account;
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region Fields
        long fDimensionKey; //Should be Composed from TableId + 7 digit
        [Persistent(@"DIMENSION_KEY"),Key]
        public long DimensionKey
        {
            get { return fDimensionKey; }
            set { SetPropertyValue<long>("DimensionKey", ref fDimensionKey, value); }
        }
        string fDimDisplayNumber;
        [Persistent(@"DIM_DISPLAY_NUM"),Size(20)]
        public string DimDisplayNumber
        {
            get { return fDimDisplayNumber; }
            set { SetPropertyValue<string>("DimDisplayNumber", ref fDimDisplayNumber, value); }
        }
        string fDimSearchName;
        [Persistent(@"DIM_SEARCH_NAME"),Size(250)]
        public string DimSearchName
        {
            get { return fDimSearchName; }
            set { SetPropertyValue<string>("DimSearchName", ref fDimSearchName, value); }
        }
        DimensionBase fDimensionBase;
        [Persistent(@"DIMENSION_BASE")]
        [Association(@"DIMBASE_DIM_HEADER_FK")]
        public DimensionBase DimensionBase
        {
            get { return fDimensionBase; }
            set { SetPropertyValue<DimensionBase>("DimensionBase", ref fDimensionBase, value); }
        }

        private Account fDimAccountBase;
        [Persistent(@"DIM_ACCOUNT_BASE")]
        public Account DimAccountBase
        {
            get { return fDimAccountBase; }
            private set { fDimAccountBase = value; }
        }

        #endregion
        #region Associations
        [Association("DIMENSION_HEADER_ACCOUNTS_FK")]
        public XPCollection<Account> Accounts { get { return GetCollection<Account>("Accounts"); } }
        #endregion
    }
}
