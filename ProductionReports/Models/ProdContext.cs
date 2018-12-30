using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace ProductionReports.Models
{
    public class ProdContext:DbContext
    {
        public const string LOCATION_DBSET = "Locations";
        public ProdContext() 
            : base("name=ProdModel")
        {

        }
        public ObjectContext ObjectContext { get { return (this as IObjectContextAdapter).ObjectContext; } }

        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentProduct> EquipmentProducts { get; set; }
        public DbSet<TransJournal> TransJournals { get; set; }
        public DbSet<TransJournalLine> TransJournalLines { get; set; }
        public DbSet<TransJournalEmployee> TransJournalEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransJournalLine>().Property(x => x.Quantity).HasPrecision(18, 6);



            base.OnModelCreating(modelBuilder);
        }


    }
}
