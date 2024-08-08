﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PfProj.Helpers;

#nullable disable

namespace PfProj.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240807195906_FullPublicEnts")]
    partial class FullPublicEnts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PfProj.Entities.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("armorClass")
                        .HasColumnType("int");

                    b.Property<int?>("baseScore")
                        .HasColumnType("int");

                    b.Property<string>("characterClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("currentHitPoints")
                        .HasColumnType("int");

                    b.Property<int?>("dex")
                        .HasColumnType("int");

                    b.Property<int?>("experience")
                        .HasColumnType("int");

                    b.Property<int?>("gold")
                        .HasColumnType("int");

                    b.Property<int?>("level")
                        .HasColumnType("int");

                    b.Property<int?>("magic")
                        .HasColumnType("int");

                    b.Property<int?>("magicAttackBonus")
                        .HasColumnType("int");

                    b.Property<int?>("magicDamageBonus")
                        .HasColumnType("int");

                    b.Property<int?>("magicResist")
                        .HasColumnType("int");

                    b.Property<int?>("maxHitPoints")
                        .HasColumnType("int");

                    b.Property<int?>("meleeAttackBonus")
                        .HasColumnType("int");

                    b.Property<int?>("meleeDamageBonus")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("rangedAttackBonus")
                        .HasColumnType("int");

                    b.Property<int?>("rangedDamageBonus")
                        .HasColumnType("int");

                    b.Property<int?>("str")
                        .HasColumnType("int");

                    b.Property<int?>("wis")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("PfProj.Entities.CharacterClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("baseScore")
                        .HasColumnType("int");

                    b.Property<string>("className")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("dex")
                        .HasColumnType("int");

                    b.Property<int?>("magic")
                        .HasColumnType("int");

                    b.Property<int?>("magicResist")
                        .HasColumnType("int");

                    b.Property<int?>("str")
                        .HasColumnType("int");

                    b.Property<int?>("wis")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CharacterClasses");
                });

            modelBuilder.Entity("PfProj.Entities.CharacterClassItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("className")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("itemID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CharacterClassItems");
                });

            modelBuilder.Entity("PfProj.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("armorClassBonus")
                        .HasColumnType("int");

                    b.Property<string>("attackType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("currentHitPointBonus")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("dexRequirement")
                        .HasColumnType("int");

                    b.Property<bool?>("isEquipped")
                        .HasColumnType("bit");

                    b.Property<int?>("magicAttackBonus")
                        .HasColumnType("int");

                    b.Property<int?>("magicDamageBonus")
                        .HasColumnType("int");

                    b.Property<int?>("magicRequirement")
                        .HasColumnType("int");

                    b.Property<int?>("maxHitPointBonus")
                        .HasColumnType("int");

                    b.Property<int?>("meleeAttackBonus")
                        .HasColumnType("int");

                    b.Property<int?>("meleeDamageBonus")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("rangedAttackBonus")
                        .HasColumnType("int");

                    b.Property<int?>("rangedDamageBonus")
                        .HasColumnType("int");

                    b.Property<string>("slotType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("strRequirement")
                        .HasColumnType("int");

                    b.Property<string>("typeOfDamage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("typeOfItem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("value")
                        .HasColumnType("int");

                    b.Property<double>("weight")
                        .HasColumnType("float");

                    b.Property<int?>("wisRequirement")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
