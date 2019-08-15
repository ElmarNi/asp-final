using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspFinal.Migrations
{
    public partial class AddedADVsCarsCountriesCities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisement_Car_CarId",
                table: "Advertisement");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertisement_City_CityId",
                table: "Advertisement");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_FuelTypes_FuelTypeId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Makes_MakeId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Transmissions_TransmissionId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Car",
                table: "Car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Advertisement",
                table: "Advertisement");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameTable(
                name: "Car",
                newName: "Cars");

            migrationBuilder.RenameTable(
                name: "Advertisement",
                newName: "Advertisements");

            migrationBuilder.RenameIndex(
                name: "IX_City_CountryId",
                table: "Cities",
                newName: "IX_Cities_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_TransmissionId",
                table: "Cars",
                newName: "IX_Cars_TransmissionId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_MakeId",
                table: "Cars",
                newName: "IX_Cars_MakeId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_FuelTypeId",
                table: "Cars",
                newName: "IX_Cars_FuelTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisement_CityId",
                table: "Advertisements",
                newName: "IX_Advertisements_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisement_CarId",
                table: "Advertisements",
                newName: "IX_Advertisements_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Advertisements",
                table: "Advertisements",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 642, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 643, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 643, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 643, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 643, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 643, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 643, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 8,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 643, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_Cars_CarId",
                table: "Advertisements",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_Cities_CityId",
                table: "Advertisements",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_FuelTypes_FuelTypeId",
                table: "Cars",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Makes_MakeId",
                table: "Cars",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Transmissions_TransmissionId",
                table: "Cars",
                column: "TransmissionId",
                principalTable: "Transmissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Cars_CarId",
                table: "Advertisements");

            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Cities_CityId",
                table: "Advertisements");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_FuelTypes_FuelTypeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Makes_MakeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Transmissions_TransmissionId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Advertisements",
                table: "Advertisements");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "Car");

            migrationBuilder.RenameTable(
                name: "Advertisements",
                newName: "Advertisement");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_CountryId",
                table: "City",
                newName: "IX_City_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_TransmissionId",
                table: "Car",
                newName: "IX_Car_TransmissionId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_MakeId",
                table: "Car",
                newName: "IX_Car_MakeId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_FuelTypeId",
                table: "Car",
                newName: "IX_Car_FuelTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisements_CityId",
                table: "Advertisement",
                newName: "IX_Advertisement_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Advertisements_CarId",
                table: "Advertisement",
                newName: "IX_Advertisement_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Car",
                table: "Car",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Advertisement",
                table: "Advertisement",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Advertisement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 8, 0, 308, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 8, 0, 309, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisement",
                keyColumn: "Id",
                keyValue: 3,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 8, 0, 309, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisement",
                keyColumn: "Id",
                keyValue: 4,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 8, 0, 309, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisement",
                keyColumn: "Id",
                keyValue: 5,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 8, 0, 309, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisement",
                keyColumn: "Id",
                keyValue: 6,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 8, 0, 309, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisement",
                keyColumn: "Id",
                keyValue: 7,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 8, 0, 309, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisement",
                keyColumn: "Id",
                keyValue: 8,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 8, 0, 309, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisement_Car_CarId",
                table: "Advertisement",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisement_City_CityId",
                table: "Advertisement",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_FuelTypes_FuelTypeId",
                table: "Car",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Makes_MakeId",
                table: "Car",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Transmissions_TransmissionId",
                table: "Car",
                column: "TransmissionId",
                principalTable: "Transmissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
