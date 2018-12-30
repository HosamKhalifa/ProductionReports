using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProductionReports.Models
{
    [Table("PRD_TransJournalEmployeesTable")]
    public class TransJournalEmployee
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecId { get; set; }
        [Required]
        public TransJournal JournalId { get; set; }
        [StringLength(7)]
        public string EmployeeAccountId { get; set; }

    }
}
