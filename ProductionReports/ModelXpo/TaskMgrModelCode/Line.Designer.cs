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

    [Persistent(@"TSK_Line")]
    public partial class Line : XPLiteObject
    {
        int fLineID;
        [Key]
        public int LineID
        {
            get { return fLineID; }
            set { SetPropertyValue<int>("LineID", ref fLineID, value); }
        }
        string fCreatedBy;
        [Size(30)]
        public string CreatedBy
        {
            get { return fCreatedBy; }
            set { SetPropertyValue<string>("CreatedBy", ref fCreatedBy, value); }
        }
        DateTime fCreatedAt;
        public DateTime CreatedAt
        {
            get { return fCreatedAt; }
            set { SetPropertyValue<DateTime>("CreatedAt", ref fCreatedAt, value); }
        }
        string fModifiedBy;
        [Size(30)]
        public string ModifiedBy
        {
            get { return fModifiedBy; }
            set { SetPropertyValue<string>("ModifiedBy", ref fModifiedBy, value); }
        }
        DateTime fModifiedAt;
        public DateTime ModifiedAt
        {
            get { return fModifiedAt; }
            set { SetPropertyValue<DateTime>("ModifiedAt", ref fModifiedAt, value); }
        }
    }

}