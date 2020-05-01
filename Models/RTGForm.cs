using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class RTGForm
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("EquipmentId")]
        public Equipment Equipment { get; set; }
        [Required]
        public string EquipmentId { get; set; }

        [Required] 
        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        [ForeignKey("CreatedById")]
        public User CreatedBy { get; set; }
        [Required] 
        public string CreatedById { get; set; }

        [ForeignKey("ModifiedById")]
        public User ModifiedBy { get; set; }
        public string ModifiedById { get; set; }

        public List<Remark> Remarks { get; set; }
        public List<Breakdown> Breakdowns { get; set; }

    }
}
