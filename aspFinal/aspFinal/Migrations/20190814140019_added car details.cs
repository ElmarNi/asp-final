using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspFinal.Migrations
{
    public partial class addedcardetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "CarDetailPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetailPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarDetailPhotos_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local), new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local), new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local), new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local), new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local), new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local), new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local), new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local), new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local), new DateTime(2019, 8, 14, 18, 0, 18, 638, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 18, 0, 18, 639, DateTimeKind.Local), new DateTime(2019, 8, 14, 18, 0, 18, 639, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 18, 0, 18, 639, DateTimeKind.Local), new DateTime(2019, 8, 14, 18, 0, 18, 639, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 18, 0, 18, 639, DateTimeKind.Local), new DateTime(2019, 8, 14, 18, 0, 18, 639, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 18, 0, 18, 639, DateTimeKind.Local), new DateTime(2019, 8, 14, 18, 0, 18, 639, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_CarDetailPhotos_CarId",
                table: "CarDetailPhotos",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarDetailPhotos");


            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CurrentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 54, 21, 854, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 54, 21, 855, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 54, 21, 855, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 54, 21, 855, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 54, 21, 855, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 54, 21, 855, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdatedDate" },
                values: new object[] { new DateTime(2019, 8, 14, 17, 54, 21, 855, DateTimeKind.Local), new DateTime(2019, 8, 14, 17, 54, 21, 855, DateTimeKind.Local) });

        }
    }
}
