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

    [NonPersistent]
    public partial class SecurityAccessType : XPLiteObject
    {
        string fAccessType;
        [Key]
        [Size(1)]
        public string AccessType
        {
            get { return fAccessType; }
            set { SetPropertyValue<string>("AccessType", ref fAccessType, value); }
        }
        int fAccessDegree;
        public int AccessDegree
        {
            get { return fAccessDegree; }
            set { SetPropertyValue<int>("AccessDegree", ref fAccessDegree, value); }
        }
        string fAccessTypeName;
        [Size(50)]
        public string AccessTypeName
        {
            get { return fAccessTypeName; }
            set { SetPropertyValue<string>("AccessTypeName", ref fAccessTypeName, value); }
        }
    }

}
