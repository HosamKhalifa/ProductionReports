using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductionReports.Models
{
    [Table("PRD_EquipmentTable")]
  public  class Equipment
    {
        [Key]
        public int EquipmentId { get; set; }
        [StringLength(250)]
        public string EquipmentName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Location LocationId { get; set; }
        public bool Active { get; set; }
        [StringLength(7)]
        public string FixedAccountId { get; set; }

    }
}
