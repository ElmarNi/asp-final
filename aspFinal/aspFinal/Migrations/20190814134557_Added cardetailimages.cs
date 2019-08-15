using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspFinal.Migrations
{
    public partial class Addedcardetailimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "CarDetailImages",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 38, 12, 47, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 38, 12, 48, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "CarDetailImages",
                columns: new[] { "Id", "CarId", "Image" },
                values: new object[,]
                {
                    { 16, 8, "car-1.jpg" },
                    { 15, 8, "car-2.jpg" },
                    { 14, 7, "car-2.jpg" },
                    { 13, 7, "car-1.jpg" },
                    { 12, 6, "car-2.jpg" },
                    { 11, 6, "car-1.jpg" },
                    { 10, 5, "car-1.jpg" },
                    { 9, 5, "car-2.jpg" },
                    { 3, 2, "car-2.jpg" },
                    { 7, 4, "car-1.jpg" },
                    { 6, 3, "car-2.jpg" },
                    { 5, 3, "car-1.jpg" },
                    { 4, 2, "car-1.jpg" },
                    { 17, 9, "car-1.jpg" },
                    { 2, 1, "car-2.jpg" },
                    { 1, 1, "car-1.jpg" },
                    { 8, 4, "car-2.jpg" },
                    { 18, 9, "car-2.jpg" }
                });
        }
    }
}
