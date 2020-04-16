using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class Equipment
    {
        [Key]
        [Column(TypeName = "NVARCHAR(15)")]
        public string Id { get; set; }
    }
}
