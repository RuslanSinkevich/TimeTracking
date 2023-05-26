﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using time_tracking.DataAccess;

#nullable disable

namespace time_tracking.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230522224720_addBDtsks_2")]
    partial class addBDtsks_2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("time_tracking.Models.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f5de4d72-25bd-4902-83ce-5c4eb1fc6051"),
                            CreateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6146),
                            ProjectName = "Проект 1",
                            UpdateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6159)
                        },
                        new
                        {
                            Id = new Guid("a3896d1e-32db-4bc7-8755-33fa6a42a45e"),
                            CreateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6162),
                            ProjectName = "Проект 2",
                            UpdateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6162)
                        },
                        new
                        {
                            Id = new Guid("c675c999-3464-426f-9b23-2bed17cefd62"),
                            CreateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6163),
                            ProjectName = "Проект 3",
                            UpdateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6164)
                        },
                        new
                        {
                            Id = new Guid("fe25e621-fd3e-4526-be35-044e18582a5c"),
                            CreateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6165),
                            ProjectName = "Проект 4",
                            UpdateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6165)
                        });
                });

            modelBuilder.Entity("time_tracking.Models.Tasks", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CancelDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TasksName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f49636b8-68c4-4613-956a-f0d8d3a3cffb"),
                            CancelDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6327),
                            CreateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6326),
                            ProjectId = new Guid("f5de4d72-25bd-4902-83ce-5c4eb1fc6051"),
                            StartDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6328),
                            TasksName = "задача 1",
                            UpdateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6326)
                        },
                        new
                        {
                            Id = new Guid("52fe2c66-c08f-4623-8d9a-f2825024fdbe"),
                            CancelDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6331),
                            CreateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6330),
                            ProjectId = new Guid("f5de4d72-25bd-4902-83ce-5c4eb1fc6051"),
                            StartDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6331),
                            TasksName = "задача 2",
                            UpdateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6330)
                        },
                        new
                        {
                            Id = new Guid("25069082-cfd2-4b6a-8e6e-ff82bd24f763"),
                            CancelDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6334),
                            CreateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6333),
                            ProjectId = new Guid("a3896d1e-32db-4bc7-8755-33fa6a42a45e"),
                            StartDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6334),
                            TasksName = "задача 1_2",
                            UpdateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6333)
                        },
                        new
                        {
                            Id = new Guid("165fb1a8-2048-4d52-89c8-1f21f9ec026e"),
                            CancelDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6336),
                            CreateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6335),
                            ProjectId = new Guid("a3896d1e-32db-4bc7-8755-33fa6a42a45e"),
                            StartDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6337),
                            TasksName = "задача 2_2",
                            UpdateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6336)
                        },
                        new
                        {
                            Id = new Guid("ca71f9a3-98c6-4d27-bf90-d987d26fa8b0"),
                            CancelDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6339),
                            CreateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6338),
                            ProjectId = new Guid("a3896d1e-32db-4bc7-8755-33fa6a42a45e"),
                            StartDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6340),
                            TasksName = "задача 1_3",
                            UpdateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6339)
                        },
                        new
                        {
                            Id = new Guid("b0e79c72-8f04-4d8f-98dd-0c724cbdeade"),
                            CancelDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6342),
                            CreateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6341),
                            ProjectId = new Guid("c675c999-3464-426f-9b23-2bed17cefd62"),
                            StartDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6342),
                            TasksName = "задача 2_3",
                            UpdateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6341)
                        },
                        new
                        {
                            Id = new Guid("44c900dc-f150-4ddc-a491-d4295716a21f"),
                            CancelDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6345),
                            CreateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6344),
                            ProjectId = new Guid("fe25e621-fd3e-4526-be35-044e18582a5c"),
                            StartDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6345),
                            TasksName = "задача 1_4",
                            UpdateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6344)
                        },
                        new
                        {
                            Id = new Guid("35c293b5-e9fc-421a-9972-c6e1fa8ca903"),
                            CancelDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6347),
                            CreateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6347),
                            ProjectId = new Guid("fe25e621-fd3e-4526-be35-044e18582a5c"),
                            StartDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6348),
                            TasksName = "задача 2_4",
                            UpdateDate = new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6347)
                        });
                });

            modelBuilder.Entity("time_tracking.Models.TasksComments", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("CommentType")
                        .HasColumnType("tinyint");

                    b.Property<byte[]>("Content")
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid>("TasksId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("TasksComments");
                });
#pragma warning restore 612, 618
        }
    }
}
