using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace time_tracking.Migrations
{
    /// <inheritdoc />
    public partial class addBDtsks_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("380bce50-227c-42ee-8b01-13e0489ca9f8"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("63635bcf-e75d-4790-bb4a-bf714ddfab6a"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("cec4bf27-3f72-4c85-a63b-f5088e069de2"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("cfb9ee4d-a11e-4148-aa19-866d3c363c57"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("40542c88-9685-4577-b691-985ce9be3e74"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("5a79a37c-31f5-4167-aa6d-4a443e407d55"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("648cf344-4c98-435b-9dcf-188e5417285a"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("66d8b04c-8e42-420c-938c-438dae31a7d4"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("9d61423d-8f1b-4c4d-975d-b3105fefa68b"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("c583be53-aeda-45f3-9254-a7bbdc2b3763"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("cda9b165-1318-409a-8293-48836fa61519"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("d7b8d698-20c1-4612-bd7e-f45ffe55564a"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("380bce50-227c-42ee-8b01-13e0489ca9f8"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2569), "Проект 1", new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2588) },
                    { new Guid("63635bcf-e75d-4790-bb4a-bf714ddfab6a"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2591), "Проект 3", new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2592) },
                    { new Guid("cec4bf27-3f72-4c85-a63b-f5088e069de2"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2590), "Проект 2", new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2590) },
                    { new Guid("cfb9ee4d-a11e-4148-aa19-866d3c363c57"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2593), "Проект 4", new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2594) }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CancelDate", "CreateDate", "ProjectId", "StartDate", "TasksName", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("40542c88-9685-4577-b691-985ce9be3e74"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2897), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2896), new Guid("380bce50-227c-42ee-8b01-13e0489ca9f8"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2898), "задача 1_3", new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2897) },
                    { new Guid("5a79a37c-31f5-4167-aa6d-4a443e407d55"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2901), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2900), new Guid("63635bcf-e75d-4790-bb4a-bf714ddfab6a"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2902), "задача 2_3", new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2900) },
                    { new Guid("648cf344-4c98-435b-9dcf-188e5417285a"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2894), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2892), new Guid("cec4bf27-3f72-4c85-a63b-f5088e069de2"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2894), "задача 2_2", new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2893) },
                    { new Guid("66d8b04c-8e42-420c-938c-438dae31a7d4"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2872), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2868), new Guid("380bce50-227c-42ee-8b01-13e0489ca9f8"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2873), "задача 1", new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2872) },
                    { new Guid("9d61423d-8f1b-4c4d-975d-b3105fefa68b"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2877), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2875), new Guid("380bce50-227c-42ee-8b01-13e0489ca9f8"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2877), "задача 2", new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2876) },
                    { new Guid("c583be53-aeda-45f3-9254-a7bbdc2b3763"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2908), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2906), new Guid("cfb9ee4d-a11e-4148-aa19-866d3c363c57"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2908), "задача 2_4", new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2907) },
                    { new Guid("cda9b165-1318-409a-8293-48836fa61519"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2904), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2903), new Guid("cfb9ee4d-a11e-4148-aa19-866d3c363c57"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2905), "задача 1_4", new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2904) },
                    { new Guid("d7b8d698-20c1-4612-bd7e-f45ffe55564a"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2890), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2888), new Guid("cec4bf27-3f72-4c85-a63b-f5088e069de2"), new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2890), "задача 1_2", new DateTime(2023, 5, 23, 5, 46, 0, 60, DateTimeKind.Local).AddTicks(2889) }
                });
        }
    }
}
