using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingApp.API.Hotels.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    HotelID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HotelName = table.Column<string>(type: "TEXT", nullable: false),
                    HotelStreetAddress = table.Column<string>(type: "TEXT", nullable: false),
                    HotelPostcode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.HotelID);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    RoomID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomType = table.Column<string>(type: "TEXT", nullable: false),
                    RoomAvailable = table.Column<bool>(type: "INTEGER", nullable: false),
                    HotelID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_Room_Hotel_HotelID",
                        column: x => x.HotelID,
                        principalTable: "Hotel",
                        principalColumn: "HotelID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Room_HotelID",
                table: "Room",
                column: "HotelID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Hotel");
        }
    }
}