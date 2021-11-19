using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingApp.API.Hotels.Migrations
{
    public partial class AddForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_Hotel_HotelID",
                table: "Room");

            migrationBuilder.AlterColumn<int>(
                name: "HotelID",
                table: "Room",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Hotel_HotelID",
                table: "Room",
                column: "HotelID",
                principalTable: "Hotel",
                principalColumn: "HotelID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_Hotel_HotelID",
                table: "Room");

            migrationBuilder.AlterColumn<int>(
                name: "HotelID",
                table: "Room",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Hotel_HotelID",
                table: "Room",
                column: "HotelID",
                principalTable: "Hotel",
                principalColumn: "HotelID");
        }
    }
}