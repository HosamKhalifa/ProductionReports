using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductionReports.Models
{
    [Table("PRD_LocationTable")]
 public class Location
    {
        [Key]
        public int LocationId { get; set; }
        [StringLength(50)]
        public string LocationName { get; set; }

    }
}
