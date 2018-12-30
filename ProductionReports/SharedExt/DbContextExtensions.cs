using ProductionReports.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionReports.SharedExt
{
  public static  class DbContextExtensions
    {
        public static int SaveChanges<TEntity>(this DbContext dbContext, IEnumerable<TEntity> bindingList, string targetDbSet)
        {
            ObjectContext objContext = (dbContext as IObjectContextAdapter).ObjectContext;
            int count = 0;
            string fullName = targetDbSet;
            System.Data.Entity.EntityState? state;
            
            foreach (var item in bindingList)
            {
                TEntity i = (TEntity)item;
                state = (System.Data.Entity.EntityState)i.GetType().GetProperty("EntityState").GetValue(i, null);
                if (state != null && state == System.Data.Entity.EntityState.Detached)
                {
                    objContext.AddObject(fullName, i);
                }
            }

            count = dbContext.SaveChanges();

            return count;

        }
    }
}
