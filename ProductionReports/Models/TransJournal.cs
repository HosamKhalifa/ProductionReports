using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductionReports.Models
{
    [Table("PRD_TransJournalTable")]
  public  class TransJournal
    {
        [Key]
        public int JournalId { get; set; }
        public Shift ShiftId { get; set; }
        public DateTime TransDate { get; set; }
        public int WorkingHours { get; set; }
        public int FaultsHours { get; set; }
        [StringLength(500)]
        public string Description { get; set; }

    }
}
