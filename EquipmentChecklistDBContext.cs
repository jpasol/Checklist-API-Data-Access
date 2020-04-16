using EquipmentChecklistDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace EquipmentChecklistDataAccess
{
    public class EquipmentChecklistDBContext: DbContext
    {
        public EquipmentChecklistDBContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Breakdown> Breakdowns { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Remark> Remarks { get; set; }
        public DbSet<RTGForm> RTGForms { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
