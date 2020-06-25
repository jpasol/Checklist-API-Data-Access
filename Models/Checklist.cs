using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class Checklist
    {
        [Key]
        public int ID { get; set; }
        
        //equipment id
        [ForeignKey("EquipmentID")]
        [Column(TypeName = "NVARCHAR(5)")]
        public Equipment Equipment { get; set; }
        public string EquipmentID { get; set; }
        //equipment id

        [Required]
        public DateTime Date_Created { get; set; }

        //user id
        [ForeignKey("UserID")]
        [Column(TypeName = "NVARCHAR(15)")]
        public User User { get; set; }
        public string UserID { get; set; }
        //user id

        public HashSet<Checklist_Item> Checklist_Items { get; set; }

    }
}
