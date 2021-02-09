using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace EquipmentChecklistDataAccess.Models
{
    public class Voucher
    {
        [ForeignKey("UserID")]
        [Column(TypeName = "NVARCHAR(15)")]
        public User User { get; set; }
        public string UserID { get; set; }

        [ForeignKey("EquipmentID")]
        [Column(TypeName = "NVARCHAR(5)")]
        public Equipment Equipment { get; set; }
        public string EquipmentID { get; set; }

        public DateTime Validity { get; set; }
    }

}
