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

        public DbSet<Checklist> Checklists { get; set; }
        public DbSet<Checklist_Item> Checklist_Items { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Equipment_Type> Equipment_Types { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Question> Questions { get; set; }  
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Checklist_Item>()
                .HasKey(c => new { c.ChecklistID, c.Equipment_TypeID, c.ComponentID, c.ConditionID });

            modelBuilder.Entity<Checklist_Item>()
                .HasOne(c => c.Question)
                .WithMany()
                .HasForeignKey(c => new { c.Equipment_TypeID, c.ComponentID})
                .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Checklist_Item>()
            //    .Property(c => c.Question).IsRequired();


            //modelBuilder.Entity<Checklist_Item>()
            //    .Property(c => c.Question).IsRequired();

            modelBuilder.Entity<Question>()
                .HasKey(c => new { c.Equipment_TypeID, c.ComponentID });

            //modelBuilder.Entity<Question>()
            //    .HasOne(c => c.Component)
            //    .WithMany()
            //    .HasForeignKey(c => c.Component);

            //modelBuilder.Entity<Question>()
            //    .HasOne(c => c.Equipment_Type)
            //    .WithMany()
            //    .HasForeignKey(c => c.Equipment_Type);



            modelBuilder.Entity<Admin>()
                .HasKey(c => new { c.UserID });

        }

    }
}
