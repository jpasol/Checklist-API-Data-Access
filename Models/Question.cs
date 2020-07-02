using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace EquipmentChecklistDataAccess.Models
{
    public class Question
    {

        //primary key defined in dbcontext

        //conditionID
        [ForeignKey("Equipment_TypeID")]
        [Column(TypeName = "NVARCHAR(5)")]
        public Equipment_Type Equipment_Type { get; set; }
        public string Equipment_TypeID { get; set; }
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
