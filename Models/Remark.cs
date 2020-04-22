using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class Remark
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        public RTGForm RTGForm { get; set; }
        [Required] 
        public Issue Issue { get; set; }
        [Required] 
        public Component Component { get; set; }
    }
}
