﻿// <auto-generated />
using System;
using CharacterData.Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CharacterData.Repo.Migrations
{
    [DbContext(typeof(CharacterContext))]
    partial class CharacterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CharacterData.Models.AbilityScores", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("characterID")
                        .HasColumnType("int");

                    b.Property<int>("dex")
                        .HasColumnType("int");

                    b.Property<int>("magic")
                        .HasColumnType("int");

                    b.Property<int>("magicResist")
                        .HasColumnType("int");

                    b.Property<int>("str")
                        .HasColumnType("int");

                    b.Property<int>("wis")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("characterID")
                        .IsUnique();

                    b.ToTable("AbilityScores");
                });

            modelBuilder.Entity("CharacterData.Models.ArmorClass", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("AC")
                        .HasColumnType("int");

                    b.Property<int>("characterID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("characterID")
                        .IsUnique();

                    b.ToTable("ArmorClass");
                });

            modelBuilder.Entity("CharacterData.Models.Character", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("characterClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("experience")
                        .HasColumnType("int");

                    b.Property<int?>("level")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("CharacterData.Models.CharacterClass", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("characterID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("characterID")
                        .IsUnique();

                    b.ToTable("CharacterClass");
                });

            modelBuilder.Entity("CharacterData.Models.Item", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Characterid")
                        .HasColumnType("int");

                    b.Property<int>("armorClassBonus")
                        .HasColumnType("int");

                    b.Property<bool?>("armsSlot")
                        .HasColumnType("bit");

                    b.Property<string>("attackType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("chestSlot")
                        .HasColumnType("bit");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dexRequirement")
                        .HasColumnType("int");

                    b.Property<bool?>("headSlot")
                        .HasColumnType("bit");

                    b.Property<int>("hitPoints")
                        .HasColumnType("int");

                    b.Property<bool?>("isEquipped")
                        .HasColumnType("bit");

                    b.Property<string>("kindOfArmor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kindOfWeapon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("leftHandSlot")
                        .HasColumnType("bit");

                    b.Property<bool?>("legsSlot")
                        .HasColumnType("bit");

                    b.Property<int>("magicAttackBonus")
                        .HasColumnType("int");

                    b.Property<int>("magicDamageBonus")
                        .HasColumnType("int");

                    b.Property<int>("magicRequirement")
                        .HasColumnType("int");

                    b.Property<int>("meleeAttackBonus")
                        .HasColumnType("int");

                    b.Property<int>("meleeDamageBonus")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("necklaceSlot")
                        .HasColumnType("bit");

                    b.Property<int>("rangedAttackBonus")
                        .HasColumnType("int");

                    b.Property<int>("rangedDamageBonus")
                        .HasColumnType("int");

                    b.Property<bool?>("rightHandSlot")
                        .HasColumnType("bit");

                    b.Property<bool?>("ringSlot")
                        .HasColumnType("bit");

                    b.Property<int>("strRequirement")
                        .HasColumnType("int");

                    b.Property<string>("typeOfDamage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("weight")
                        .HasColumnType("float");

                    b.Property<int>("wisRequirement")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Characterid");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("CharacterData.Models.HitPoints", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("characterID")
                        .HasColumnType("int");

                    b.Property<int>("hitPoints")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("characterID")
                        .IsUnique();

                    b.ToTable("HitPoints");
                });

            modelBuilder.Entity("CharacterData.Models.MagicAttack", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("characterID")
                        .HasColumnType("int");

                    b.Property<int>("magicAttackBonus")
                        .HasColumnType("int");

                    b.Property<int>("magicDamageBonus")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("characterID")
                        .IsUnique();

                    b.ToTable("MagicAttack");
                });

            modelBuilder.Entity("CharacterData.Models.MeleeAttack", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("characterID")
                        .HasColumnType("int");

                    b.Property<int>("meleeAttackBonus")
                        .HasColumnType("int");

                    b.Property<int>("meleeDamageBonus")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("characterID")
                        .IsUnique();

                    b.ToTable("MeleeAttack");
                });

            modelBuilder.Entity("CharacterData.Models.RangedAttack", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("characterID")
                        .HasColumnType("int");

                    b.Property<int>("rangedAttackBonus")
                        .HasColumnType("int");

                    b.Property<int>("rangedDamageBonus")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("characterID")
                        .IsUnique();

                    b.ToTable("RangedAttack");
                });

            modelBuilder.Entity("CharacterData.Models.AbilityScores", b =>
                {
                    b.HasOne("CharacterData.Models.Character", "character")
                        .WithOne("abilityScores")
                        .HasForeignKey("CharacterData.Models.AbilityScores", "characterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("character");
                });

            modelBuilder.Entity("CharacterData.Models.ArmorClass", b =>
                {
                    b.HasOne("CharacterData.Models.Character", "character")
                        .WithOne("armorClass")
                        .HasForeignKey("CharacterData.Models.ArmorClass", "characterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("character");
                });

            modelBuilder.Entity("CharacterData.Models.CharacterClass", b =>
                {
                    b.HasOne("CharacterData.Models.Character", "character")
                        .WithOne("characterClass")
                        .HasForeignKey("CharacterData.Models.CharacterClass", "characterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("character");
                });

            modelBuilder.Entity("CharacterData.Models.Item", b =>
                {
                    b.HasOne("CharacterData.Models.Character", null)
                        .WithMany("inventory")
                        .HasForeignKey("Characterid");
                });

            modelBuilder.Entity("CharacterData.Models.HitPoints", b =>
                {
                    b.HasOne("CharacterData.Models.Character", "character")
                        .WithOne("hitPoints")
                        .HasForeignKey("CharacterData.Models.HitPoints", "characterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("character");
                });

            modelBuilder.Entity("CharacterData.Models.MagicAttack", b =>
                {
                    b.HasOne("CharacterData.Models.Character", "character")
                        .WithOne("magicAttack")
                        .HasForeignKey("CharacterData.Models.MagicAttack", "characterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("character");
                });

            modelBuilder.Entity("CharacterData.Models.MeleeAttack", b =>
                {
                    b.HasOne("CharacterData.Models.Character", "character")
                        .WithOne("meleeAttack")
                        .HasForeignKey("CharacterData.Models.MeleeAttack", "characterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("character");
                });

            modelBuilder.Entity("CharacterData.Models.RangedAttack", b =>
                {
                    b.HasOne("CharacterData.Models.Character", "character")
                        .WithOne("rangedAttack")
                        .HasForeignKey("CharacterData.Models.RangedAttack", "characterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("character");
                });

            modelBuilder.Entity("CharacterData.Models.Character", b =>
                {
                    b.Navigation("abilityScores")
                        .IsRequired();

                    b.Navigation("armorClass");

                    b.Navigation("characterClass");

                    b.Navigation("hitPoints")
                        .IsRequired();

                    b.Navigation("inventory");

                    b.Navigation("magicAttack");

                    b.Navigation("meleeAttack");

                    b.Navigation("rangedAttack");
                });
#pragma warning restore 612, 618
        }
    }
}
