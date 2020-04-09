using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EquipmentChecklistDataAccess.Models
{
    public partial class Issues
    {
        [Key]
        public int Key { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
