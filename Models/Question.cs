using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class Question
    {

        //primary key defined in dbcontext

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
        public string ComponentID { get; set; }
        //componentID

        [Column(TypeName = "NVARCHAR(150)")]
        public string Question_Text { get; set; }
        public int Rank { get; set; }

    }
}
