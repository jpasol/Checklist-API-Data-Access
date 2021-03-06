﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EquipmentChecklistDataAccess.Models
{
    public class Equipment
    {
        [Key]
        [Column(TypeName = "NVARCHAR(5)")]
        public string ID { get; set; }

        [ForeignKey("Equipment_TypeID")]
        [Column(TypeName = "NVARCHAR(5)")]
        public Equipment_Type Equipment_Type { get; set; }
        public string Equipment_TypeID { get; set; }

        [Column(TypeName = "NVARCHAR(15)")]
        public string Shortname { get; set; }


    }
}
