﻿// <auto-generated />
using ExcelTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExcelTest.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230710171829_Datatable")]
    partial class Datatable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExcelTest.Models.Allergies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AllergiesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("ExcelTest.Models.Allergies_Details", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AllergiesID")
                        .HasColumnType("int");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AllergiesID");

                    b.HasIndex("PatientID");

                    b.ToTable("Allergies_Details");
                });

            modelBuilder.Entity("ExcelTest.Models.DiseasesInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DiseasesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Enums")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DiseasesInformation");
                });

            modelBuilder.Entity("ExcelTest.Models.NCD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NCDName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NCDs");
                });

            modelBuilder.Entity("ExcelTest.Models.NCD_Details", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("NCDId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("NCDId");

                    b.HasIndex("PatientId");

                    b.ToTable("NCD_Details");
                });

            modelBuilder.Entity("ExcelTest.Models.Patients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DiseasesId")
                        .HasColumnType("int");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DiseasesId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("ExcelTest.Models.Allergies_Details", b =>
                {
                    b.HasOne("ExcelTest.Models.Allergies", "Allergies")
                        .WithMany()
                        .HasForeignKey("AllergiesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExcelTest.Models.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Allergies");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ExcelTest.Models.NCD_Details", b =>
                {
                    b.HasOne("ExcelTest.Models.NCD", "NCD")
                        .WithMany()
                        .HasForeignKey("NCDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExcelTest.Models.Patients", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NCD");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ExcelTest.Models.Patients", b =>
                {
                    b.HasOne("ExcelTest.Models.DiseasesInformation", "Diseases")
                        .WithMany()
                        .HasForeignKey("DiseasesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diseases");
                });
#pragma warning restore 612, 618
        }
    }
}