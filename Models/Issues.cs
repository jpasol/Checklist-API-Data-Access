using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class Issues
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
