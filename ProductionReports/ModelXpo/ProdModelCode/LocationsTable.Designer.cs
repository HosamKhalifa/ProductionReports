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

    public partial class LocationsTable : XPLiteObject
    {
        int fLocationID;
        [Key]
        public int LocationID
        {
            get { return fLocationID; }
            set { SetPropertyValue<int>("LocationID", ref fLocationID, value); }
        }
        string fLocationName;
        [Size(50)]
        public string LocationName
        {
            get { return fLocationName; }
            set { SetPropertyValue<string>("LocationName", ref fLocationName, value); }
        }
        string fPOSAccountID;
        [Size(7)]
        public string POSAccountID
        {
            get { return fPOSAccountID; }
            set { SetPropertyValue<string>("POSAccountID", ref fPOSAccountID, value); }
        }
    }

}
