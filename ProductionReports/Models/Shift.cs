using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductionReports.Models
{
    [Table("PRD_ShiftTable")]
public class Shift
    {
        [Key]
        public int ShiftId { get; set; }
        [StringLength(50)]
        public string ShiftName { get; set; }
    }
}
