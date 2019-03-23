using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ProductionReports.ModelXpo.OmarERP
{

    public partial class ArticalCategory
    {
        public ArticalCategory(Session session) : base(session) { }
        public override void AfterConstruction()
        {
           

            base.AfterConstruction();
        }

        protected override void OnSaving()
        {
            var accessInfo = SecurityUser.UserPermission(this.GetType().Name);

            if (accessInfo.AccessDegree < 2 )
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
