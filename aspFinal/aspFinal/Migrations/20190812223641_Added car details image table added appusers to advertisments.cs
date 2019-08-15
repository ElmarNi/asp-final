using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspFinal.Migrations
{
    public partial class Addedcardetailsimagetableaddedappuserstoadvertisments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Advertisements",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CarDetailImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(nullable: true),
                    CarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetailImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarDetailImages_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "CurrentDate", "UpdatedDate" },
                values: new object[] { "6f7d0122-db19-4071-941f-57792706dbe0", new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApplicationUserId", "CurrentDate", "UpdatedDate" },
                values: new object[] { "6f7d0122-db19-4071-941f-57792706dbe0", new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApplicationUserId", "CurrentDate", "UpdatedDate" },
                values: new object[] { "6f7d0122-db19-4071-941f-57792706dbe0", new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApplicationUserId", "CurrentDate", "UpdatedDate" },
                values: new object[] { "6f7d0122-db19-4071-941f-57792706dbe0", new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApplicationUserId", "CurrentDate", "UpdatedDate" },
                values: new object[] { "6f7d0122-db19-4071-941f-57792706dbe0", new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ApplicationUserId", "CurrentDate", "UpdatedDate" },
                values: new object[] { "6f7d0122-db19-4071-941f-57792706dbe0", new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ApplicationUserId", "CurrentDate", "UpdatedDate" },
                values: new object[] { "6f7d0122-db19-4071-941f-57792706dbe0", new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ApplicationUserId", "CurrentDate", "UpdatedDate" },
                values: new object[] { "6f7d0122-db19-4071-941f-57792706dbe0", new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 36, 41, 17, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 36, 41, 17, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 36, 41, 17, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 36, 41, 17, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 36, 41, 17, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 36, 41, 17, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 13, 2, 36, 41, 17, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 36, 41, 17, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "CarDetailImages",
                columns: new[] { "Id", "CarId", "Image" },
                values: new object[,]
                {
                    { 14, 7, "car-2.jpg" },
                    { 13, 7, "car-1.jpg" },
                    { 12, 6, "car-2.jpg" },
                    { 11, 6, "car-1.jpg" },
                    { 10, 5, "car-1.jpg" },
                    { 9, 5, "car-2.jpg" },
                    { 8, 4, "car-2.jpg" },
                    { 2, 1, "car-2.jpg" },
                    { 6, 3, "car-2.jpg" },
                    { 5, 3, "car-1.jpg" },
                    { 4, 2, "car-1.jpg" },
                    { 3, 2, "car-2.jpg" },
                    { 15, 8, "car-2.jpg" },
                    { 1, 1, "car-1.jpg" },
                    { 7, 4, "car-1.jpg" },
                    { 16, 8, "car-1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Description", "FuelTypeId", "Image", "IsVip", "MakeId", "ManufactureYear", "Millage", "Motor", "Price", "TransmissionId" },
                values: new object[] { 9, "Black", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 1, "car-1.jpg", false, 4, 2006, 0, 1.8m, 11000m, 1 });

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "ApplicationUserId", "CarId", "CityId", "CurrentDate", "UpdatedDate" },
                values: new object[] { 9, "6f7d0122-db19-4071-941f-57792706dbe0", 9, 3, new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local), new DateTime(2019, 8, 13, 2, 36, 41, 16, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "CarDetailImages",
                columns: new[] { "Id", "CarId", "Image" },
                values: new object[] { 17, 9, "car-1.jpg" });

            migrationBuilder.InsertData(
                table: "CarDetailImages",
                columns: new[] { "Id", "CarId", "Image" },
                values: new object[] { 18, 9, "car-2.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_ApplicationUserId",
                table: "Advertisements",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetailImages_CarId",
                table: "CarDetailImages",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_AspNetUsers_ApplicationUserId",
                table: "Advertisements",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_AspNetUsers_ApplicationUserId",
                table: "Advertisements");

            migrationBuilder.DropTable(
                name: "CarDetailImages");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_ApplicationUserId",
                table: "Advertisements");

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Advertisements");

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
    }
}
