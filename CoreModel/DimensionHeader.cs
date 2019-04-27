﻿using DevExpress.Xpo;
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
        [Persistent(@"DIM_DISPLAY_NUM"),Size(9)]
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

        #endregion
        #region Associations
        [Association("DIMENSION_HEADER_ACCOUNTS_FK")]
        public XPCollection<Account> Accounts { get { return GetCollection<Account>("Accounts"); } }
        #endregion
    }
}