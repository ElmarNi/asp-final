using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspFinal.Migrations
{
    public partial class Addedblogmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Image = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Content = table.Column<string>(nullable: false),
                    ShortContent = table.Column<string>(maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 23, 3, 37, 513, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 23, 3, 37, 513, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 23, 3, 37, 513, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 23, 3, 37, 513, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 23, 3, 37, 513, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 23, 3, 37, 513, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 23, 3, 37, 513, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 8,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 23, 3, 37, 513, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "CreateDate", "Image", "ShortContent", "Title" },
                values: new object[,]
                {
                    { 1, "The British firm’s racing arm has been investigating a full-time IndyCar programme since backing double Formula 1 world champion Fernando Alonso’s entry in the 2017 Indianapolis 500 in a Honda-powered Andretti Autosport car. The Spaniard nearly won that event, and returned this year for a one-off drive in a standalone McLaren-run car with Chevrolet engines, but failed to qualify for the event.Under the new partnership, the existing Schmidt Peterson team will be renamed Arrow McLaren Racing SP, and will switch from the Honda engines it has used this year to Chevrolet units.McLaren said that the “infrastructure of Arrow SPM [will] underpin the team’s operations, while McLaren adds technical expertise, commercial experience and marketing strength”.There is no word yet on drivers for next season. IndyCar race winner James Hinchcliffe and ex-Formula 1 racer Marcus Ericsson currently drive for the team. Alonso has previously expressed interest in an expanded IndyCar programme, although it is not known if he would be interested in a full-time campaign.Team co-founders Sam Schmidt and Ric Peterson will continue in their current roles, with McLaren sporting director Gil de Ferran leading the McLaren involvement. A dedicated group from McLaren Racing will work on the programme.De Ferran, who won back-to-back driver’s titles in the CART World Series in 2000 and 2001, said: ““IndyCar is a natural fit for McLaren, given our legacy and determination to succeed at the top levels of international motorsport. Our ambition, over time, is to consistently compete for wins and championships.”", new DateTime(2019, 8, 10, 23, 3, 37, 513, DateTimeKind.Local), "1mclarenindy.jpg", "Formula 1 outfit links up with Arrow Schmidt Peterson Motorsport to run a pair of Chevrolet-powered cars in 2020", "McLaren secures partnership for full-time IndyCar entry" },
                    { 2, "The Affalterbach firm is developing two four-wheel-drive versions of the GLB, in both 35 4Matic and 45 4Matic trim. The 35 version, which will feature the same 302bhp 2.0-litre mild hybrid petrol engine found in the A35 hot hatch, is set to be revealed at Frankfurt, with sales starting later this year.The Mercedes-AMG GLB has previously been spied undergoing development work in both variants. It is differentiated from standard versions by its reduced ride height, larger brake discs, multi-pot calipers and four tailpipes, as opposed to the twin-exit arrangement of the less powerful GLB 35 4Matic prototypes we’ve seen previously.The GLB 45, due on sale next year to rival the Audi RS Q3, is among a number of new Mercedes-AMG models set to run a newly developed four-cylinder engine based on Mercedes’ turbocharged 2.0-litre 'M260' unit.Also due to appear in the A45 4Matic, CLA 45, CLA 45 Shooting Brake and GLA 45, the new powerplant is claimed to develop 382bhp in standard guise and 416bhp in a higher state of tune.In the GLB 45, the new engine will be mated to an eight-speed dual-clutch automatic gearbox and a new four-wheel drive system developed in a partnership between AMG and Austrian engineering specialist Magna Powertrain. It uses electrohydraulic actuation instead of the electromechanical operation of the four-wheel drive system by transverse engine models built by AMG up to now.Among the developments incorporated on the new four-wheel drive system is a rear differential featuring two separate clutches. They allow it to apportion up to 100% of power to each of the individual rear wheels in a so-called drift mode that AMG sources have revealed to Autocar will feature on all upcoming 45-badged models.The GLB 45 is set to crown the upcoming GLB line-up when it goes on sale in 2020. It will be positioned above the GLB 35, which runs a milder 302bhp turbocharged 2.0-litre four-cylinder petrol engine and is set to form part of the initial GLB line-up that's planned to be launched in early June.The GLB is the eighth member of Mercedes’ compact car line-up. In standard guise, it offers the choice of either five or seven seats. ", new DateTime(2019, 8, 10, 23, 3, 37, 513, DateTimeKind.Local), "img_4980.jpg", "High-performance four-wheel-drive version of new compact SUV set to go on sale in 2020", "Hot Mercedes-AMG GLB SUV set for Frankfurt reveal" },
                    { 3, "The latest version of the Korean firm’s compact SUV, which joins the existing petrol, diesel and fully electric models, will be offered in three trim levels, all of which will use the same 1.6-litre petrol-electric powertrain.That unit, taken from Kia’s larger Niro, makes 104bhp on its own and is mated to a 43bhp electric motor also powering the front wheels. Both are linked through a six-speed dual-clutch automatic gearbox and a small (1.56kWh) lithium ion battery that recharges through coasting and braking. Total system output is 139bhp, with a combined torque figure of 195lb ft. That’s sufficient for a 0-62mph time of 11.2sec on the smallest wheel size, and a maximum speed of just under 100mph.The hybrid is considerably more frugal on paper than the normal petrol equivalents, managing a claimed 72mpg (66mpg on 18in wheels) and CO2 emissions of 90g/km (99g/km on 18in wheels). For comparison, Hyundai claims the base 1.0 T-GDI petrol engine manages 54.3mpg combined. Entry-level Kona Hybrid SE models feature climate control, 16in wheels with a design bespoke to the hybrid version, special badges and unique white accents on the air vents and gear level. There is a 7in touchscreen with Apple CarPlay and Android Auto connectivity, rear parking sensors and camera and lane-keeping assist.The mid-level Kona Hybrid Premium starts at £24,295, and additions include 18in wheels, a 10.25in touchscreen, Krell sound system, keyless entry, privacy glass and wireless smartphone charging.The top Premium SE trim level is priced from £27,195 and includes the likes of LED front and rear lights, standard autonomous emergency braking, heated and ventilated leather seats and a head-up display.All three trim levels are available with different versions of Hyundai’s SmartSense safety packs as options.The £22,495 starting price for the Kona Hybrid compares to £17,305 for the petrol, and £27,250 for the electric version.", new DateTime(2019, 8, 10, 23, 3, 37, 513, DateTimeKind.Local), "1734339_all-new_kona_hybrid_1.jpg", "Petrol-electric crossover will be capable of 75mpg, and available to buy in September", "New Hyundai Kona Hybrid to start from £22,495" },
                    { 4, "It’s the latest of a number of test mules seen in the last few days, including a new 3 Series-based B3 and the brand’s take on the new X7 SUV. While the former was expected, the two new models will take Alpina’s range of BMW-derived models to eight.As with the B3 and XB7, this 8 Series test car wears the tell-tale addenda of an Alpina model. These include bespoke bumper designs, the trademark multi-spoke wheel design and unique badging. It’s likely, although not yet confirmed, that the same treatment will be applied to the two-door coupé and cabriolet 8 Series models in due course.Likely to be called the B8, the new Alpina four-door will make use of the M850i’s twin-turbocharged 4.4-litre petrol V8 rather than the full-fat M8's version. However, it will be tuned to a power output of 600bhp, as is traditional. Using the identically powered B5 for comparison, that would translate to a 0-62mph time of well below four seconds and a top speed breaking the 200mph barrier (Alpina doesn’t use electronic speed limiters).We can also expect Alpina’s highly acclaimed chassis engineers to work their magic on the 8 Series, giving it a unique suspension tune that prioritises comfort just as much as handling. The interior, too, will receive upholstery upgrades as part of the usual makeover.No details of the B8's launch have been released yet, but given the M8 is due to go on sale in the next couple of months, we expect a debut in the first half of 2020 at the latest. ", new DateTime(2019, 8, 10, 23, 3, 37, 513, DateTimeKind.Local), "img_6434.jpg", "Alpina’s flurry of new model launches looks set to continue, with prototypes of its version of the new BMW 8 Series Gran Coupé having emerged.", "Alpina version of BMW 8 Series Gran Coupe seen testing" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 597, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 598, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 598, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 598, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 598, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 598, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 598, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 8,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 598, DateTimeKind.Local));
        }
    }
}
