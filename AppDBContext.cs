using EquipmentChecklistDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EquipmentChecklistDataAccess
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Components> Components { get; set; }
        public DbSet<Issues> Issues { get; set; }
    }
}
