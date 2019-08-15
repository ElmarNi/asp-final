using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspFinal.Migrations
{
    public partial class Addedupdateddatetoblogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Blogs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 0, 59, 15, 408, DateTimeKind.Local), new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local), new DateTime(2019, 8, 13, 0, 59, 15, 409, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 0, 59, 15, 410, DateTimeKind.Local), new DateTime(2019, 8, 13, 0, 59, 15, 410, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 0, 59, 15, 410, DateTimeKind.Local), new DateTime(2019, 8, 13, 0, 59, 15, 410, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 0, 59, 15, 410, DateTimeKind.Local), new DateTime(2019, 8, 13, 0, 59, 15, 410, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Blogs");

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 12, 22, 18, 43, 205, DateTimeKind.Local), new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local), new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local), new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local), new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local), new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local), new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local), new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local), new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2019, 8, 12, 22, 18, 43, 206, DateTimeKind.Local));
        }
    }
}
