using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class User
    {
        [Key]
        [Column(TypeName = "NVARCHAR(15)")]
        public string Id { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string Name { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string Password { get; set; }

        [Column(TypeName = "BIT")]
        public bool isActive { get; set; }
    }
}
