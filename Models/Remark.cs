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
        public RTGForm RTGForm { get; set; }
        public Issue Issue { get; set; }
        public Component Component { get; set; }
    }
}
