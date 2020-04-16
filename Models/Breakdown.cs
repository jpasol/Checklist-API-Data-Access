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
        public RTGForm RTGForm { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }

        [Column(TypeName = "NVARCHAR(150)")]
        public string Description { get; set; }
    }
}
