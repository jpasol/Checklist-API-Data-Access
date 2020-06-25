using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class Checklist_Item
    {
        //composite key added in DBContext 

        //checklistId
        [ForeignKey("ChecklistID")]
        [Column(TypeName = "NVARCHAR(5)")]
        public Checklist Checklist { get; set; }
        public int ChecklistID { get; set; }
        //checklist id


        //conditionID
        [ForeignKey("EquipmentID")]
        [Column(TypeName = "NVARCHAR(5)")]
        public Equipment Equipment { get; set; }
        public string EquipmentID { get; set; }
        //conditionID

        //componentID
        [ForeignKey("ComponentID")]
        [Column(TypeName = "NVARCHAR(5)")]
        public Component Component { get; set; }
        public string ComponentID{ get; set; }
        //componentID

        //conditionID
        [ForeignKey("ConditionID")]
        [Column(TypeName = "NVARCHAR(5)")]
        public Condition Condition { get; set; }
        public string ConditionID { get; set; }
        //conditionID


    }
}
