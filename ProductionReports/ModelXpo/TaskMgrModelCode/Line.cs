using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ProductionReports.ModelXpo.OmarERP
{

    public partial class Line
    {
        public Line(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            this.CreatedBy = SecurityUser.CurrentUser.UserId;
            this.CreatedAt = DateTime.Now;

            this.ModifiedBy = SecurityUser.CurrentUser.UserId;
            this.ModifiedAt = DateTime.Now;
            this.LineID = SecurityUser.NextLineVal(Session);

            base.AfterConstruction();
        }
        protected override void OnSaving()
        {
            this.ModifiedBy = SecurityUser.CurrentUser.UserId;
            this.ModifiedAt = DateTime.Now;
            base.OnSaving();
        }
    }

}
