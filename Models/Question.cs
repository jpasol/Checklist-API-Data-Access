using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace EquipmentChecklistDataAccess.Models
{
    public class Question
    {

        //primary key defined in dbcontext

        //conditionID
        [ForeignKey("Equipment_Type")]
        [Column(TypeName = "NVARCHAR(5)", Order = 0)]
        public string Equipment_TypeID { get; set; }
        //conditionID

        //componentID
        [ForeignKey("Component")]
        [Column(TypeName = "NVARCHAR(5)", Order = 1)]
        public string ComponentID { get; set; }
        //componentID

        [Column(TypeName = "NVARCHAR(150)")]
        public string Question_Text { get; set; }
        public int Rank { get; set; }

        [Required]
        public virtual Equipment_Type Equipment_Type { get; set; }
        [Required]
        public virtual Component Component { get; set; }

    }
}
