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

    [Persistent(@"VendorAccountEntityView")]
    public partial class VendorAccount_EV : XPLiteObject
    {
        string fAccountID;
        [Key]
        [Size(7)]
        public string AccountID
        {
            get { return fAccountID; }
            set { SetPropertyValue<string>("AccountID", ref fAccountID, value); }
        }
        string fName;
        [Size(250)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>("Name", ref fName, value); }
        }
        string fAddress;
        [Size(300)]
        public string Address
        {
            get { return fAddress; }
            set { SetPropertyValue<string>("Address", ref fAddress, value); }
        }
    }

}
