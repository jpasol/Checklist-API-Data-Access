using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EquipmentChecklistDataAccess.Models
{
    public partial class EquipmentChecklistDBContext : DbContext
    { 
        public EquipmentChecklistDBContext(DbContextOptions<EquipmentChecklistDBContext> options)
            : base(options)
        {
        }

        public DbSet<Components> Components { get; set; }
        public DbSet<Issues> Issues { get; set; }
    }
}
