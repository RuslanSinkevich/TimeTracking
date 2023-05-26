using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace time_tracking.Migrations
{
    /// <inheritdoc />
    public partial class addBDtsks_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("a3896d1e-32db-4bc7-8755-33fa6a42a45e"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("c675c999-3464-426f-9b23-2bed17cefd62"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("f5de4d72-25bd-4902-83ce-5c4eb1fc6051"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("fe25e621-fd3e-4526-be35-044e18582a5c"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("165fb1a8-2048-4d52-89c8-1f21f9ec026e"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("25069082-cfd2-4b6a-8e6e-ff82bd24f763"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("35c293b5-e9fc-421a-9972-c6e1fa8ca903"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("44c900dc-f150-4ddc-a491-d4295716a21f"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("52fe2c66-c08f-4623-8d9a-f2825024fdbe"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("b0e79c72-8f04-4d8f-98dd-0c724cbdeade"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("ca71f9a3-98c6-4d27-bf90-d987d26fa8b0"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("f49636b8-68c4-4613-956a-f0d8d3a3cffb"));

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "CreateDate", "ProjectName", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("2f656964-f8e9-4e4b-8d19-8a0106e70b96"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6019), "Проект 1", new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6030) },
                    { new Guid("bd3792ee-cbbb-4d61-81c0-9968c6759356"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6033), "Проект 3", new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6034) },
                    { new Guid("ea604709-b5ad-4b6a-99aa-d351bd714df8"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6035), "Проект 4", new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6035) },
                    { new Guid("f1725f3e-3c53-4e22-87ab-207d73399b95"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6032), "Проект 2", new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6032) }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CancelDate", "CreateDate", "ProjectId", "StartDate", "TasksName", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("038e08f6-a053-4d3a-95dd-7ff4b4b9a90f"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6143), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6142), new Guid("2f656964-f8e9-4e4b-8d19-8a0106e70b96"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6144), "задача 2", new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6143) },
                    { new Guid("166c7718-cc5c-4627-b658-29b9cf7de57c"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6148), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6148), new Guid("f1725f3e-3c53-4e22-87ab-207d73399b95"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6149), "задача 2_2", new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6148) },
                    { new Guid("69ec4aa2-eab0-48b1-950a-17f4d113bb7e"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6153), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6153), new Guid("bd3792ee-cbbb-4d61-81c0-9968c6759356"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6154), "задача 2_3", new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6153) },
                    { new Guid("aca626c9-0e21-488f-ba3e-b045671e98a9"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6159), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6158), new Guid("ea604709-b5ad-4b6a-99aa-d351bd714df8"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6159), "задача 2_4", new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6158) },
                    { new Guid("d1a2d1d3-baca-471b-82fb-779d478b722a"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6146), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6145), new Guid("f1725f3e-3c53-4e22-87ab-207d73399b95"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6146), "задача 1_2", new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6145) },
                    { new Guid("dc85494a-9d3d-4182-995b-ceb853b3ebf0"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6151), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6150), new Guid("bd3792ee-cbbb-4d61-81c0-9968c6759356"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6151), "задача 1_3", new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6150) },
                    { new Guid("e77e1961-b3a3-48ec-99bf-9b55edda4ce3"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6140), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6139), new Guid("2f656964-f8e9-4e4b-8d19-8a0106e70b96"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6140), "задача 1", new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6139) },
                    { new Guid("ffbada9e-10d6-428d-9285-6b29e91bd48d"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6156), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6155), new Guid("ea604709-b5ad-4b6a-99aa-d351bd714df8"), new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6156), "задача 1_4", new DateTime(2023, 5, 23, 5, 48, 20, 1, DateTimeKind.Local).AddTicks(6156) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("2f656964-f8e9-4e4b-8d19-8a0106e70b96"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("bd3792ee-cbbb-4d61-81c0-9968c6759356"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("ea604709-b5ad-4b6a-99aa-d351bd714df8"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("f1725f3e-3c53-4e22-87ab-207d73399b95"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("038e08f6-a053-4d3a-95dd-7ff4b4b9a90f"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("166c7718-cc5c-4627-b658-29b9cf7de57c"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("69ec4aa2-eab0-48b1-950a-17f4d113bb7e"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("aca626c9-0e21-488f-ba3e-b045671e98a9"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d1a2d1d3-baca-471b-82fb-779d478b722a"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("dc85494a-9d3d-4182-995b-ceb853b3ebf0"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("e77e1961-b3a3-48ec-99bf-9b55edda4ce3"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("ffbada9e-10d6-428d-9285-6b29e91bd48d"));

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "CreateDate", "ProjectName", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("a3896d1e-32db-4bc7-8755-33fa6a42a45e"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6162), "Проект 2", new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6162) },
                    { new Guid("c675c999-3464-426f-9b23-2bed17cefd62"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6163), "Проект 3", new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6164) },
                    { new Guid("f5de4d72-25bd-4902-83ce-5c4eb1fc6051"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6146), "Проект 1", new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6159) },
                    { new Guid("fe25e621-fd3e-4526-be35-044e18582a5c"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6165), "Проект 4", new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6165) }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CancelDate", "CreateDate", "ProjectId", "StartDate", "TasksName", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("165fb1a8-2048-4d52-89c8-1f21f9ec026e"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6336), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6335), new Guid("a3896d1e-32db-4bc7-8755-33fa6a42a45e"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6337), "задача 2_2", new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6336) },
                    { new Guid("25069082-cfd2-4b6a-8e6e-ff82bd24f763"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6334), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6333), new Guid("a3896d1e-32db-4bc7-8755-33fa6a42a45e"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6334), "задача 1_2", new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6333) },
                    { new Guid("35c293b5-e9fc-421a-9972-c6e1fa8ca903"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6347), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6347), new Guid("fe25e621-fd3e-4526-be35-044e18582a5c"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6348), "задача 2_4", new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6347) },
                    { new Guid("44c900dc-f150-4ddc-a491-d4295716a21f"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6345), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6344), new Guid("fe25e621-fd3e-4526-be35-044e18582a5c"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6345), "задача 1_4", new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6344) },
                    { new Guid("52fe2c66-c08f-4623-8d9a-f2825024fdbe"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6331), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6330), new Guid("f5de4d72-25bd-4902-83ce-5c4eb1fc6051"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6331), "задача 2", new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6330) },
                    { new Guid("b0e79c72-8f04-4d8f-98dd-0c724cbdeade"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6342), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6341), new Guid("c675c999-3464-426f-9b23-2bed17cefd62"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6342), "задача 2_3", new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6341) },
                    { new Guid("ca71f9a3-98c6-4d27-bf90-d987d26fa8b0"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6339), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6338), new Guid("a3896d1e-32db-4bc7-8755-33fa6a42a45e"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6340), "задача 1_3", new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6339) },
                    { new Guid("f49636b8-68c4-4613-956a-f0d8d3a3cffb"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6327), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6326), new Guid("f5de4d72-25bd-4902-83ce-5c4eb1fc6051"), new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6328), "задача 1", new DateTime(2023, 5, 23, 5, 47, 20, 582, DateTimeKind.Local).AddTicks(6326) }
                });
        }
    }
}
