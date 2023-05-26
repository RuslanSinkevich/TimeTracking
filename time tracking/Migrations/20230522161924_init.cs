using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace time_tracking.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TasksName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CancelDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TasksComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TasksId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommentType = table.Column<byte>(type: "tinyint", nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksComments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "CreateDate", "ProjectName", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1c54f073-904a-4b97-a4cb-27cb5d21f983"), new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1841), "Проект 4", new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1841) },
                    { new Guid("c3ce01d3-93ae-4016-a407-e94d30061660"), new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1824), "Проект 1", new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1834) },
                    { new Guid("f38595bc-c0c3-4587-a2cc-2666392d7802"), new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1839), "Проект 3", new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1840) },
                    { new Guid("f72e6eb0-2345-447f-8d51-496a8aa83214"), new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1837), "Проект 2", new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1838) }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CancelDate", "CreateDate", "ProjectId", "StartDate", "TasksName", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0d286d92-9595-47f7-8d5c-8faa01a28e3d"), new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1962), new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1961), new Guid("c3ce01d3-93ae-4016-a407-e94d30061660"), new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1962), "задача 2", new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1961) },
                    { new Guid("a62eff1d-25ae-4cbd-92fe-f981296a2fba"), new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1958), new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1957), new Guid("c3ce01d3-93ae-4016-a407-e94d30061660"), new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1959), "задача 1", new DateTime(2023, 5, 22, 23, 19, 24, 460, DateTimeKind.Local).AddTicks(1958) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "TasksComments");
        }
    }
}
