using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class Component
    {
        [Key]
        [Column(TypeName = "NVARCHAR(5)")]
        public string ID { get; set; }
        [Column(TypeName = "NVARCHAR(15)")]
        public string Shortname { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string Description { get; set; }

        public virtual HashSet<Question> Questions { get; set; }
    }
}
