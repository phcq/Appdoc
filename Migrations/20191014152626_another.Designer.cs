﻿// <auto-generated />
using System;
using App4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App4.Migrations
{
    [DbContext(typeof(App4Context))]
    [Migration("20191014152626_another")]
    partial class another
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("App4.Models.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDiagnosis")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("PacientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PacientId");

                    b.ToTable("Disease");
                });

            modelBuilder.Entity("App4.Models.Pacient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DiseaseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pacient");
                });

            modelBuilder.Entity("App4.Models.Disease", b =>
                {
                    b.HasOne("App4.Models.Pacient", null)
                        .WithMany("Disease")
                        .HasForeignKey("PacientId");
                });
#pragma warning restore 612, 618
        }
    }
}
