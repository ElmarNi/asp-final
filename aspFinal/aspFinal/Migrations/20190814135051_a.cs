using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspFinal.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 50, 51, 624, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 50, 51, 625, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 45, 56, 695, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 45, 56, 696, DateTimeKind.Local) });
        }
    }
}
