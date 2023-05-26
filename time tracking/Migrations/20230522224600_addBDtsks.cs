using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace time_tracking.Migrations
{
    /// <inheritdoc />
    public partial class addBDtsks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("1c54f073-904a-4b97-a4cb-27cb5d21f983"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("c3ce01d3-93ae-4016-a407-e94d30061660"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("f38595bc-c0c3-4587-a2cc-2666392d7802"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: new Guid("f72e6eb0-2345-447f-8d51-496a8aa83214"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("0d286d92-9595-47f7-8d5c-8faa01a28e3d"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("a62eff1d-25ae-4cbd-92fe-f981296a2fba"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
