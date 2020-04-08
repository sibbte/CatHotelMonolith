using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatHotel_Monolith.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    TeleNumber = table.Column<string>(nullable: true),
                    MobNumber = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    Town = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Cats = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    RoomNo = table.Column<int>(nullable: false),
                    RoomType = table.Column<int>(nullable: false),
                    MaxNoOfCatsInRoom = table.Column<int>(nullable: false),
                    CheckedIn = table.Column<bool>(nullable: false),
                    CheckedOut = table.Column<bool>(nullable: false),
                    Booked = table.Column<bool>(nullable: true),
                    BookingStart = table.Column<DateTime>(nullable: true),
                    BookingEnd = table.Column<DateTime>(nullable: true),
                    Available = table.Column<bool>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    RoomID = table.Column<Guid>(nullable: true),
                    CustomerID = table.Column<Guid>(nullable: true),
                    BookingMade = table.Column<DateTime>(nullable: false),
                    CheckedIn = table.Column<bool>(nullable: true),
                    CheckedOut = table.Column<bool>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    CatsAmount = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    CCTV = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    TagID = table.Column<string>(nullable: true),
                    Vaccination = table.Column<bool>(nullable: false),
                    DateOfLastVac = table.Column<DateTime>(nullable: false),
                    MealType = table.Column<int>(nullable: false),
                    CatName = table.Column<string>(nullable: true),
                    CatLitter = table.Column<string>(nullable: true),
                    CatCharacter = table.Column<string>(nullable: true),
                    CatVetName = table.Column<string>(nullable: true),
                    CatVetAddress1 = table.Column<string>(nullable: true),
                    CatVetAddress2 = table.Column<string>(nullable: true),
                    CatVetPostCode = table.Column<string>(nullable: true),
                    CatVetCity = table.Column<string>(nullable: true),
                    CatVetPhoneNo = table.Column<string>(nullable: true),
                    CatMedicalCondition = table.Column<string>(nullable: true),
                    ChekedIn = table.Column<bool>(nullable: true),
                    ChekedOut = table.Column<bool>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    BookingID = table.Column<Guid>(nullable: true),
                    CustomerID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cats_Bookings_BookingID",
                        column: x => x.BookingID,
                        principalTable: "Bookings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cats_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerID",
                table: "Bookings",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomID",
                table: "Bookings",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Cats_BookingID",
                table: "Cats",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_Cats_CustomerID",
                table: "Cats",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
