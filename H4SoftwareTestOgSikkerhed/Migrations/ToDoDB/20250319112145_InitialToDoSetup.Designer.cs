﻿// <auto-generated />
using H4SoftwareTestOgSikkerhed.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace H4SoftwareTestOgSikkerhed.Migrations.ToDoDB
{
    [DbContext(typeof(ToDoDBContext))]
    [Migration("20250319112145_InitialToDoSetup")]
    partial class InitialToDoSetup
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("H4SoftwareTestOgSikkerhed.Models.Cpr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CprNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cprs");
                });

            modelBuilder.Entity("H4SoftwareTestOgSikkerhed.Models.ToDoList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CprIDId")
                        .HasColumnType("int");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CprIDId");

                    b.ToTable("ToDoLists");
                });

            modelBuilder.Entity("H4SoftwareTestOgSikkerhed.Models.ToDoList", b =>
                {
                    b.HasOne("H4SoftwareTestOgSikkerhed.Models.Cpr", "CprID")
                        .WithMany()
                        .HasForeignKey("CprIDId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CprID");
                });
#pragma warning restore 612, 618
        }
    }
}
