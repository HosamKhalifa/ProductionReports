﻿using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ProductionReports.ModelXpo.OmarERP
{

    public partial class Tracker
    {
        public Tracker(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
