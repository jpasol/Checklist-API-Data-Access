﻿// <auto-generated />
using System;
using EquipmentChecklistDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EquipmentChecklistDataAccess.Migrations
{
    [DbContext(typeof(EquipmentChecklistDBContext))]
    partial class EquipmentChecklistDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Admin", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("NVARCHAR(15)");

                    b.HasKey("UserID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Checklist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("EquipmentID")
                        .HasColumnType("NVARCHAR(5)");

                    b.Property<string>("UserID")
                        .HasColumnType("NVARCHAR(15)");

                    b.HasKey("ID");

                    b.HasIndex("EquipmentID");

                    b.HasIndex("UserID");

                    b.ToTable("Checklists");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Checklist_Item", b =>
                {
                    b.Property<int>("ChecklistID")
                        .HasColumnType("int");

                    b.Property<string>("Equipment_TypeID")
                        .HasColumnType("NVARCHAR(5)");

                    b.Property<string>("ComponentID")
                        .HasColumnType("NVARCHAR(5)");

                    b.Property<string>("ConditionID")
                        .HasColumnType("NVARCHAR(5)");

                    b.Property<string>("Remarks")
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("ChecklistID", "Equipment_TypeID", "ComponentID", "ConditionID");

                    b.HasIndex("ComponentID");

                    b.HasIndex("ConditionID");

                    b.HasIndex("Equipment_TypeID", "ComponentID");

                    b.ToTable("Checklist_Items");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Component", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("NVARCHAR(5)");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(150)");

                    b.Property<string>("Shortname")
                        .HasColumnType("NVARCHAR(15)");

                    b.HasKey("ID");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Condition", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("NVARCHAR(5)");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(150)");

                    b.Property<string>("Shortname")
                        .HasColumnType("NVARCHAR(15)");

                    b.HasKey("ID");

                    b.ToTable("Conditions");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Equipment", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("NVARCHAR(5)");

                    b.Property<string>("Equipment_TypeID")
                        .HasColumnType("NVARCHAR(5)");

                    b.Property<string>("Shortname")
                        .HasColumnType("NVARCHAR(15)");

                    b.HasKey("ID");

                    b.HasIndex("Equipment_TypeID");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Equipment_Type", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("NVARCHAR(5)");

                    b.Property<string>("Shortname")
                        .HasColumnType("NVARCHAR(15)");

                    b.HasKey("ID");

                    b.ToTable("Equipment_Types");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Question", b =>
                {
                    b.Property<string>("Equipment_TypeID")
                        .HasColumnType("NVARCHAR(5)");

                    b.Property<string>("ComponentID")
                        .HasColumnType("NVARCHAR(5)");

                    b.Property<string>("Question_Text")
                        .HasColumnType("NVARCHAR(150)");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.HasKey("Equipment_TypeID", "ComponentID");

                    b.HasIndex("ComponentID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.User", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("NVARCHAR(15)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(25)");

                    b.Property<bool>("isActive")
                        .HasColumnType("BIT");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Admin", b =>
                {
                    b.HasOne("EquipmentChecklistDataAccess.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Checklist", b =>
                {
                    b.HasOne("EquipmentChecklistDataAccess.Models.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentID");

                    b.HasOne("EquipmentChecklistDataAccess.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("Equipment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Checklist_Item", b =>
                {
                    b.HasOne("EquipmentChecklistDataAccess.Models.Checklist", "Checklist")
                        .WithMany("Checklist_Items")
                        .HasForeignKey("ChecklistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EquipmentChecklistDataAccess.Models.Component", "Component")
                        .WithMany()
                        .HasForeignKey("ComponentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EquipmentChecklistDataAccess.Models.Condition", "Condition")
                        .WithMany()
                        .HasForeignKey("ConditionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EquipmentChecklistDataAccess.Models.Equipment_Type", "Equipment_Type")
                        .WithMany()
                        .HasForeignKey("Equipment_TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EquipmentChecklistDataAccess.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("Equipment_TypeID", "ComponentID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Checklist");

                    b.Navigation("Component");

                    b.Navigation("Condition");

                    b.Navigation("Equipment_Type");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Equipment", b =>
                {
                    b.HasOne("EquipmentChecklistDataAccess.Models.Equipment_Type", "Equipment_Type")
                        .WithMany()
                        .HasForeignKey("Equipment_TypeID");

                    b.Navigation("Equipment_Type");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Question", b =>
                {
                    b.HasOne("EquipmentChecklistDataAccess.Models.Component", "Component")
                        .WithMany("Questions")
                        .HasForeignKey("ComponentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EquipmentChecklistDataAccess.Models.Equipment_Type", "Equipment_Type")
                        .WithMany("Questions")
                        .HasForeignKey("Equipment_TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Component");

                    b.Navigation("Equipment_Type");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Checklist", b =>
                {
                    b.Navigation("Checklist_Items");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Component", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("EquipmentChecklistDataAccess.Models.Equipment_Type", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
