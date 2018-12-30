using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductionReports.Models
{
    [Table("PRD_EquipmentProductsTable")]
public   class EquipmentProduct
    {
        [Key]
        public int ProductId { get; set; }
        public Equipment EquipmentId { get; set; }
        [StringLength(7)]
        public string SalesAccountId { get; set; }

    }
}
