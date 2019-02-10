using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace ProductionReports.ModelXpo.OmarERP
{

    public partial class TransJournalLine
    {
        public TransJournalLine(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        protected override void OnSaving()
        {
            var jour = this.JournalId;
            if (jour.IsApproved == 1 || !SecurityUser.IsCreator())
            {
                this.Reload();
                throw new Exception("This is a Read only record  ");

            }
            base.OnSaving();
            jour.ModifiedBy = SecurityUser.CurrentUser.UserId;
            jour.ModifiedAt = DateTime.Now;
        }
    }

}
