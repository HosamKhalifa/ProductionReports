using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ProductionReports.ModelXpo.OmarERP
{

    public partial class TransJournalEmployees
    {
        public TransJournalEmployees(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
        protected override void OnSaving()
        {
            if ( this.JournalId.IsApproved == 1 ||!SecurityUser.IsCreator())
            {
                this.Reload();
                throw new Exception("This is a Read only record  ");

            }
            base.OnSaving();
        }
    }

}
