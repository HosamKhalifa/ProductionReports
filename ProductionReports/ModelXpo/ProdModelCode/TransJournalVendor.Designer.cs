﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ProductionReports.ModelXpo.OmarERP
{

    [Persistent(@"PRD_TransJournalVendorTable")]
    public partial class TransJournalVendor : XPLiteObject
    {
        int fRecId;
        [Key(true)]
        public int RecId
        {
            get { return fRecId; }
            set { SetPropertyValue<int>("RecId", ref fRecId, value); }
        }
        TransJournal fJournalId;
        public TransJournal JournalId
        {
            get { return fJournalId; }
            set { SetPropertyValue<TransJournal>("JournalId", ref fJournalId, value); }
        }
        VendorTransType fTransType;
        public VendorTransType TransType
        {
            get { return fTransType; }
            set { SetPropertyValue<VendorTransType>("TransType", ref fTransType, value); }
        }
        string fTransVendorAccountID;
        public string TransVendorAccountID
        {
            get { return fTransVendorAccountID; }
            set { SetPropertyValue<string>("TransVendorAccountID", ref fTransVendorAccountID, value); }
        }
    }

}
