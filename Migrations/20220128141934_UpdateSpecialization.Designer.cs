﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineCatalog.Data;

#nullable disable

namespace OnlineCatalog.Migrations
{
    [DbContext(typeof(OnlineCatalogContext))]
    [Migration("20220128141934_UpdateSpecialization")]
    partial class UpdateSpecialization
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnlineCatalog.Models.Grade", b =>
                {
                    b.Property<int>("GradeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeID"), 1L, 1);

                    b.Property<decimal>("GradeValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("GradeID");

                    b.HasIndex("StudentID");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("OnlineCatalog.Models.Specialization", b =>
                {
                    b.Property<int>("SpecializationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecializationID"), 1L, 1);

                    b.Property<string>("SpecializationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpecializationID");

                    b.ToTable("Specialization");
                });

            modelBuilder.Entity("OnlineCatalog.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrMatricol")
                        .HasColumnType("int");

                    b.Property<int>("SpecializationID")
                        .HasColumnType("int");

                    b.HasKey("StudentID");

                    b.HasIndex("SpecializationID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("OnlineCatalog.Models.Grade", b =>
                {
                    b.HasOne("OnlineCatalog.Models.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("OnlineCatalog.Models.Student", b =>
                {
                    b.HasOne("OnlineCatalog.Models.Specialization", "Specialization")
                        .WithMany("Students")
                        .HasForeignKey("SpecializationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("OnlineCatalog.Models.Specialization", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("OnlineCatalog.Models.Student", b =>
                {
                    b.Navigation("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}
