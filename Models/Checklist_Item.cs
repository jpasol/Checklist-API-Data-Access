using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class Checklist_Item
    {
        //composite key added in DBContext 

        //checklistId
        [ForeignKey("Checklist")]
        public int ChecklistID { get; set; }
        //checklist id

        //conditionID
        [ForeignKey("Equipment_Type")]
        [Column(TypeName = "NVARCHAR(5)", Order = 1)]
        public string Equipment_TypeID { get; set; }
        //conditionID

        //componentID
        [ForeignKey("Component")]
        [Column(TypeName = "NVARCHAR(5)", Order = 2)]
        public string ComponentID { get; set; }
        //componentID


        //conditionID
        [ForeignKey("Condition")]
        [Column(TypeName = "NVARCHAR(5)")]
        public string ConditionID { get; set; }
        //conditionID

        [Column(TypeName = "NVARCHAR(50)")]
        public string Remarks { get; set; }

        [Required]
        public Question Question { get; set; }
        [Required]
        public Condition Condition { get; set; }
        [Required]
        public Component Component { get; set; }
        [Required]
        public Checklist Checklist { get; set; }
        [Required]
        public Equipment_Type Equipment_Type { get; set; }

    }
}
