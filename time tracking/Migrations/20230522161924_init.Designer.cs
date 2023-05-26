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
    [Migration("20230522161924_init")]
    partial class init
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
                            Id = new Guid("c3ce01d3-93ae-4016-a407-e94d30061660"),
                            CreateDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1824),
                            ProjectName = "Проект 1",
                            UpdateDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1834)
                        },
                        new
                        {
                            Id = new Guid("f72e6eb0-2345-447f-8d51-496a8aa83214"),
                            CreateDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1837),
                            ProjectName = "Проект 2",
                            UpdateDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1838)
                        },
                        new
                        {
                            Id = new Guid("f38595bc-c0c3-4587-a2cc-2666392d7802"),
                            CreateDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1839),
                            ProjectName = "Проект 3",
                            UpdateDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1840)
                        },
                        new
                        {
                            Id = new Guid("1c54f073-904a-4b97-a4cb-27cb5d21f983"),
                            CreateDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1841),
                            ProjectName = "Проект 4",
                            UpdateDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1841)
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
                            Id = new Guid("a62eff1d-25ae-4cbd-92fe-f981296a2fba"),
                            CancelDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1958),
                            CreateDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1957),
                            ProjectId = new Guid("c3ce01d3-93ae-4016-a407-e94d30061660"),
                            StartDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1959),
                            TasksName = "задача 1",
                            UpdateDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1958)
                        },
                        new
                        {
                            Id = new Guid("0d286d92-9595-47f7-8d5c-8faa01a28e3d"),
                            CancelDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1962),
                            CreateDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1961),
                            ProjectId = new Guid("c3ce01d3-93ae-4016-a407-e94d30061660"),
                            StartDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1962),
                            TasksName = "задача 2",
                            UpdateDate = new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1961)
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