﻿// <auto-generated />
using FrechettteZacharyTp4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FrechettteZacharyTp4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240407192635_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FrechettteZacharyTp4.Models.Abonnements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("PrixMensuel")
                        .HasColumnType("real");

                    b.Property<int>("RabaisPourcentage")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Abonnements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PrixMensuel = 0f,
                            RabaisPourcentage = 0,
                            Type = "Regulier"
                        },
                        new
                        {
                            Id = 2,
                            PrixMensuel = 50f,
                            RabaisPourcentage = 10,
                            Type = "Argent"
                        },
                        new
                        {
                            Id = 3,
                            PrixMensuel = 100f,
                            RabaisPourcentage = 15,
                            Type = "Or"
                        });
                });

            modelBuilder.Entity("FrechettteZacharyTp4.Models.Clients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AbonnementId")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Courriel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoTelephone")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AbonnementId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("FrechettteZacharyTp4.Models.Clients", b =>
                {
                    b.HasOne("FrechettteZacharyTp4.Models.Abonnements", "Abonnement")
                        .WithMany()
                        .HasForeignKey("AbonnementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Abonnement");
                });
#pragma warning restore 612, 618
        }
    }
}
