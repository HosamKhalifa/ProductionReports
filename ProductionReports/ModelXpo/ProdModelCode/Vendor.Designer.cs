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

    [Persistent(@"PRD_VendorTable")]
    public partial class Vendor : XPLiteObject
    {
        VendorAccount_EV fAccountID;
        [Key]
        [Size(7)]
        public VendorAccount_EV AccountID
        {
            get { return fAccountID; }
            set { SetPropertyValue<VendorAccount_EV>("AccountID", ref fAccountID, value); }
        }
        string fDescription;
        [Size(250)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        int? fActive;
        public int? Active
        {
            get { return fActive; }
            set { SetPropertyValue<int?>("Active", ref fActive, value); }
        }
    }

}
