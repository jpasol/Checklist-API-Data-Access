using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class Breakdown
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        public RTGForm RTGForm { get; set; }
        [Required] 
        public DateTime TimeStart { get; set; }
        [Required] 
        public DateTime TimeEnd { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(150)")]
        public string Description { get; set; }
    }
}
