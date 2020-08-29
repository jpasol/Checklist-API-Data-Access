using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class Admin
    {

        [ForeignKey("UserID")]

        public User User { get; set; }
        public string UserID { get; set; }

    }
}
