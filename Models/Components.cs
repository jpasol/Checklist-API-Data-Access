using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class Components
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Component { get; set; }
    }
}
