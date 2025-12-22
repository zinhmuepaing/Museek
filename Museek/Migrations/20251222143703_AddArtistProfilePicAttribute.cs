using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museek.Migrations
{
    /// <inheritdoc />
    public partial class AddArtistProfilePicAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Profile_Pic",
                table: "Artist",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8a49b1b-3c52-4064-9e11-694c1eede0f4", "AQAAAAIAAYagAAAAEJE/XvQyN2yY3NE4agCPC6jAOLeamIdwiwWSHRksODgUzFxe/7dFgKlvc5gnLoc9lQ==", "5871e74e-4426-4042-ab89-562e0a951e4d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profile_Pic",
                table: "Artist");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fa895f3-9a18-401c-8680-eadcaa2d15ff", "AQAAAAIAAYagAAAAEKKKhRa4O09B3RJdmWSw9acmlfbP1RZM/ZjgIFKoWeAegh/YB3mjZQ8Pei0RRzY/Vw==", "cc86c699-62f7-4517-bb11-9ceb995a8e2a" });
        }
    }
}
