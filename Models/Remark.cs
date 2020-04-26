using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class Remark
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RTGFormId")]
        public RTGForm RTGForm { get; set; }
        [Required] 
        public int RTGFormId { get; set; }
        [ForeignKey("IssueId")]
        public Issue Issue { get; set; }
        [Required] 
        public string IssueId { get; set; }
        [ForeignKey("ComponentId")]
        public Component Component { get; set; }
        [Required] 
        public string ComponentId { get; set; }
    }
}
