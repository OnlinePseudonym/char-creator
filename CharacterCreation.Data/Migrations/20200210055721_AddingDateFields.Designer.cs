﻿// <auto-generated />
using System;
using CharacterCreation.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CharacterCreation.Data.Migrations
{
    [DbContext(typeof(CharCreationContext))]
    [Migration("20200210055721_AddingDateFields")]
    partial class AddingDateFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CharacterCreation.Data.Entities.BaseClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("BaseStatAdjustmentId")
                        .HasColumnType("int");

                    b.Property<int?>("MaxStatAdjustmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("BaseStatAdjustmentId");

                    b.HasIndex("MaxStatAdjustmentId");

                    b.ToTable("BaseClasses");
                });

            modelBuilder.Entity("CharacterCreation.Data.Entities.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("Constitution")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Spirit")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("CharacterCreation.Data.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BaseClassId")
                        .HasColumnType("int");

                    b.Property<int?>("BaseStatAdjustmentId")
                        .HasColumnType("int");

                    b.Property<int?>("MaxStatAdjustmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("BaseClassId");

                    b.HasIndex("BaseStatAdjustmentId");

                    b.HasIndex("MaxStatAdjustmentId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("CharacterCreation.Data.Entities.StatAdjustment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int?>("CharacterId1")
                        .HasColumnType("int");

                    b.Property<int>("Constitution")
                        .HasColumnType("int");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<int>("Spirit")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("CharacterId1");

                    b.ToTable("StatAdjustment");
                });

            modelBuilder.Entity("CharacterCreation.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CharacterCreation.Data.Entities.BaseClass", b =>
                {
                    b.HasOne("CharacterCreation.Data.Entities.StatAdjustment", "BaseStatAdjustment")
                        .WithMany()
                        .HasForeignKey("BaseStatAdjustmentId");

                    b.HasOne("CharacterCreation.Data.Entities.StatAdjustment", "MaxStatAdjustment")
                        .WithMany()
                        .HasForeignKey("MaxStatAdjustmentId");
                });

            modelBuilder.Entity("CharacterCreation.Data.Entities.Character", b =>
                {
                    b.HasOne("CharacterCreation.Data.Entities.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CharacterCreation.Data.Entities.User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterCreation.Data.Entities.Class", b =>
                {
                    b.HasOne("CharacterCreation.Data.Entities.BaseClass", "BaseClass")
                        .WithMany("PromotionClasses")
                        .HasForeignKey("BaseClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CharacterCreation.Data.Entities.StatAdjustment", "BaseStatAdjustment")
                        .WithMany()
                        .HasForeignKey("BaseStatAdjustmentId");

                    b.HasOne("CharacterCreation.Data.Entities.StatAdjustment", "MaxStatAdjustment")
                        .WithMany()
                        .HasForeignKey("MaxStatAdjustmentId");
                });

            modelBuilder.Entity("CharacterCreation.Data.Entities.StatAdjustment", b =>
                {
                    b.HasOne("CharacterCreation.Data.Entities.Character", null)
                        .WithMany("BaseStatAdjustments")
                        .HasForeignKey("CharacterId");

                    b.HasOne("CharacterCreation.Data.Entities.Character", null)
                        .WithMany("MaxStatAdjustments")
                        .HasForeignKey("CharacterId1");
                });
#pragma warning restore 612, 618
        }
    }
}
