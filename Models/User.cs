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
        public string ID { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(25)")]
        public string FirstName { get; set; }
        [Column(TypeName = "NVARCHAR(20)")]
        public string MiddleName { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(20)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(25)")]
        [MinLength(8)]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "BIT")]
        public bool isActive { get; set; }
    }
}
