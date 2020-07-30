﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Threenine.Diogel.Database.Postgre.Migrations
{
    [DbContext(typeof(DiogelContext))]
    partial class SwcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Threenine.Diogel.Database.Entity.Threats.Classification", b =>
                {
                    b.Property<Guid>("ThreatId")
                        .HasColumnName("identifier")
                        .HasColumnType("uuid");

                    b.Property<int>("StatusId")
                        .HasColumnName("status_id")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnName("type_id")
                        .HasColumnType("int");

                    b.HasKey("ThreatId", "StatusId", "TypeId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.ToTable("classification");
                });

            modelBuilder.Entity("Threenine.Diogel.Database.Entity.Threats.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("varchar")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("varchar")
                        .HasMaxLength(45);

                    b.HasKey("Id");

                    b.ToTable("status");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A current active threat",
                            Name = "Active"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Highly dangerous threat",
                            Name = "Malign"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Active threat but not known to harmful",
                            Name = "Benign"
                        });
                });

            modelBuilder.Entity("Threenine.Diogel.Database.Entity.Threats.Threat", b =>
                {
                    b.Property<Guid>("Identifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("identifier")
                        .HasColumnType("uuid");

                    b.Property<string>("Host")
                        .HasColumnName("host")
                        .HasColumnType("varchar")
                        .HasMaxLength(41);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar")
                        .HasMaxLength(55);

                    b.Property<string>("Protocol")
                        .HasColumnName("protocol")
                        .HasColumnType("varchar")
                        .HasMaxLength(256);

                    b.Property<string>("QueryString")
                        .HasColumnName("query_string")
                        .HasColumnType("varchar")
                        .HasMaxLength(256);

                    b.Property<string>("Referer")
                        .HasColumnName("referrer")
                        .HasColumnType("varchar")
                        .HasMaxLength(256);

                    b.Property<string>("UserAgent")
                        .HasColumnName("user_agent")
                        .HasColumnType("varchar")
                        .HasMaxLength(35);

                    b.Property<string>("XForwardHost")
                        .HasColumnName("x_forward_host")
                        .HasColumnType("varchar")
                        .HasMaxLength(256);

                    b.Property<string>("XForwardProto")
                        .HasColumnName("x_forward_proto")
                        .HasColumnType("varchar")
                        .HasMaxLength(256);

                    b.HasKey("Identifier");

                    b.HasIndex("Identifier")
                        .IsUnique()
                        .HasName("identifier");

                    b.ToTable("threat");
                });

            modelBuilder.Entity("Threenine.Diogel.Database.Entity.Threats.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("varchar")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("varchar")
                        .HasMaxLength(45);

                    b.HasKey("Id");

                    b.ToTable("type");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "a Referrer spammer",
                            Name = "Referrer Spam"
                        },
                        new
                        {
                            Id = 2,
                            Description = "potential search engine or index spider",
                            Name = "Web Crawler"
                        });
                });

            modelBuilder.Entity("Threenine.Diogel.Database.Entity.Threats.Classification", b =>
                {
                    b.HasOne("Threenine.Diogel.Database.Entity.Threats.Status", "Status")
                        .WithMany("Classifications")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Threenine.Diogel.Database.Entity.Threats.Threat", "Threat")
                        .WithMany()
                        .HasForeignKey("ThreatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Threenine.Diogel.Database.Entity.Threats.Type", "Type")
                        .WithMany("Classifications")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}