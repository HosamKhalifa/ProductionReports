using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductionReports.Models
{
    [Table("PRD_TransJournalLineTable")]
  public  class TransJournalLine
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecId { get; set; }
        public TransJournal JournalId { get; set; }
        public EquipmentProduct ProductId { get; set; }
        public decimal Quantity { get; set; }
        [StringLength(500)]
        public string LineDescription { get; set; }
    }
}
