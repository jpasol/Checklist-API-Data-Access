using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EquipmentChecklistDataAccess.Models
{
    public partial class Components
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Component { get; set; }
    }
}
