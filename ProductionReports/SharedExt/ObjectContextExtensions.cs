using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightERP.SharedExt
{
 public  static class ObjectContextExtensions

    {
        /// <summary>
        /// This method for saving DataBindings collection linked to EntitySet .
        /// This method assuming naming convention of DbSet as EntityClassName + 'Set' as suffix
        /// </summary>
        /// <typeparam name="TEntity">Passing Entity Class  </typeparam>
        /// <param name="dbContext">Pass ObjectContext which created by Devart Entity Developer</param>
        /// <param name=""></param>
        /// <returns></returns>
        public static int SaveChanges<TEntity> (this ObjectContext dbContext, IEnumerable<TEntity> bindingList)
        {
            int count = 0;
            string fullName = "";
            System.Data.Entity.EntityState? state;
            foreach (var item in bindingList)
            {
                fullName = item.GetType().Name;
                TEntity i = (TEntity)item;
                state = (System.Data.Entity.EntityState) i.GetType().GetProperty("EntityState").GetValue(i, null);
                if(state != null && state == System.Data.Entity.EntityState.Detached)
                {
                    dbContext.AddObject(fullName, i);
                }
            }

            count = dbContext.SaveChanges();
            return count;
        }
        public static int SaveChanges<TEntity>(this ObjectContext dbContext, IEnumerable<TEntity> bindingList,string targetDbSet)
        {
            int count = 0;
            string fullName = targetDbSet;
            System.Data.Entity.EntityState? state;
            foreach (var item in bindingList)
            {
                
                TEntity i = (TEntity)item;
                state = (System.Data.Entity.EntityState)i.GetType().GetProperty("EntityState").GetValue(i, null);
                if (state != null && state == System.Data.Entity.EntityState.Detached)
                {
                    dbContext.AddObject(fullName, i);
                }
            }

            count = dbContext.SaveChanges();
            return count;
        }
    }
}
