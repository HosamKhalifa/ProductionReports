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

    [Persistent(@"PRD_TransJournalTable")]
    public partial class TransJournal : XPLiteObject
    {
        int fJournalId;
        [Key(true)]
        public int JournalId
        {
            get { return fJournalId; }
            set { SetPropertyValue<int>("JournalId", ref fJournalId, value); }
        }
        int fShiftId;
        public int ShiftId
        {
            get { return fShiftId; }
            set { SetPropertyValue<int>("ShiftId", ref fShiftId, value); }
        }
        DateTime fTransDate;
        public DateTime TransDate
        {
            get { return fTransDate; }
            set { SetPropertyValue<DateTime>("TransDate", ref fTransDate, value); }
        }
        decimal fWorkingHours;
        public decimal WorkingHours
        {
            get { return fWorkingHours; }
            set { SetPropertyValue<decimal>("WorkingHours", ref fWorkingHours, value); }
        }
        decimal fFaultsHours;
        public decimal FaultsHours
        {
            get { return fFaultsHours; }
            set { SetPropertyValue<decimal>("FaultsHours", ref fFaultsHours, value); }
        }
        string fDecription;
        [Size(500)]
        public string Decription
        {
            get { return fDecription; }
            set { SetPropertyValue<string>("Decription", ref fDecription, value); }
        }
        [Association(@"TransJournalLineReferencesTransJournal")]
        public XPCollection<TransJournalLine> TransJournalLines { get { return GetCollection<TransJournalLine>("TransJournalLines"); } }
    }

}
