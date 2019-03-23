using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ProductionReports.ModelXpo.OmarERP
{

    public partial class TransJournal
    {
        public TransJournal(Session session) : base(session)
        {
            
        }
        public override void AfterConstruction()
        {
            this.CreatedBy = SecurityUser.CurrentUser.UserId;
            this.CreatedAt = DateTime.Now;

            this.ModifiedBy = SecurityUser.CurrentUser.UserId;
            this.ModifiedAt = DateTime.Now;

            base.AfterConstruction();
        }
        protected override void OnSaving()
        {
            if(IsApproved == 1 || !SecurityUser.IsCreator())
            {
                this.Reload();
                throw new Exception("This is a Read only record  ");
               
            }
            this.ModifiedBy = SecurityUser.CurrentUser.UserId;
            this.ModifiedAt = DateTime.Now;
            base.OnSaving();
        }

       
    }

}
