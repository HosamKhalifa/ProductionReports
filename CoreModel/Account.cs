﻿using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModel
{
    [Persistent(@"ACT_TB")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class Account :Line
    {
        public Account(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            //Default display number to temp sequence
            DisplayNumber = GetDefaultDisplayNumber();
            base.AfterConstruction();
        }

        #region Methods
        
        public virtual string GetDefaultDisplayNumber()
        {
            var sequ =  GLParms.GLParameters(Session).TempAccountSequ;
            return sequ.NextValue(CoreLib.FormRecord.EffectiveDate);
        }


        #endregion

        #region Fields
        /*
        string fDimensionValue;
        [Size(9)]
        [Persistent(@"DIM_VAL")]
        
        public string DimensionValue
        {
            get { return fDimensionValue; }
            set { SetPropertyValue<string>("DimensionValue", ref fDimensionValue, value); }
        }
        */
        DimensionHeader fDimensionHeader;
        [Persistent(@"DIM_HEADER")]
        [Association("DIMENSION_HEADER_ACCOUNTS_FK")]
        public DimensionHeader DimensionHeader
        {
            get { return fDimensionHeader; }
            set { SetPropertyValue<DimensionHeader>("DimensionHeader", ref fDimensionHeader, value); }
        }

        string fDisplayNumber;
        [Size(9)]
        [Persistent(@"DISPLAY_NUMBER")]
        public string DisplayNumber
        {
            get { return fDisplayNumber; }
            set { SetPropertyValue<string>("DisplayNumber", ref fDisplayNumber, value); }
        }
        string fName;
        [Size(250)]
        [Persistent(@"NAME")]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>("Name", ref fName, value); }
        }
        string fDescription;
        [Size(250)]
        [Persistent(@"DESCRIPTION")]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        bool fActive;
        [Persistent(@"ACTIVE")]
        public bool Active
        {
            get { return fActive; }
            set { SetPropertyValue<bool>("Active", ref fActive, value); }
        }
        AccountRef1 fReferenceNumber1;
        [Persistent(@"REF_NO1")]
        [Association(@"ACT_REFNO1_ACCOUNTS_FK")]
        public AccountRef1 ReferenceNumber1
        {
            get { return fReferenceNumber1; }
            set { SetPropertyValue<AccountRef1>("ReferenceNumber1", ref fReferenceNumber1, value); }
        }
        AccountRef2 fReferenceNumber2;
        [Persistent(@"REF_NO2")]
        [Association(@"ACT_REFNO2_ACCOUNTS_FK")]
        public AccountRef2 ReferenceNumber2
        {
            get { return fReferenceNumber2; }
            set { SetPropertyValue<AccountRef2>("ReferenceNumber2", ref fReferenceNumber2, value); }
        }
        AccountGroup fGroupId;
        [Persistent(@"GROUP_ID")]
        [Association(@"ACT_GRP_ACCOUNTS")]
        public AccountGroup GroupId
        {
            get { return fGroupId; }
            set { SetPropertyValue<AccountGroup>("GroupId", ref fGroupId, value); }
        }
        string fReferenceNumber;
        [Size(120)]
        [Persistent(@"REF_NUM")]
        public string ReferenceNumber
        {
            get { return fReferenceNumber; }
            set { SetPropertyValue<string>("ReferenceNumber", ref fReferenceNumber, value); }
        }

        AddressBook fPrimaryAddress;
        [Persistent(@"PRIMARY_ADDRESS")]

        public AddressBook PrimaryAddress
        {
            get { return fPrimaryAddress; }
            set { SetPropertyValue<AddressBook>("PrimaryAddress", ref fPrimaryAddress, value); }
        }
        #endregion

        #region Associations
        [Association(@"Account-Addresses")]
        public XPCollection<AddressBook> AccountAddresses { get { return GetCollection<AddressBook>("AccountAddresses"); } }

      
      
        #endregion

        #region Events
        protected override void OnSaving()
        {
            if(TableId != null && Session.IsNewObject(this))
            {
                var dimBase = Session.GetObjectByKey<DimensionBase>(TableId.TableId);//Test if TableId has Dimension 
                if (dimBase != null)
                {
                    DimensionHeader = DimensionBase.FindOrCreateDimHeader(this);
                }
               
            }
            
            base.OnSaving();
        }
        #endregion

    }
}
