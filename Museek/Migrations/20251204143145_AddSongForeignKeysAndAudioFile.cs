using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museek.Migrations
{
    /// <inheritdoc />
    public partial class AddSongForeignKeysAndAudioFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistSong");

            migrationBuilder.DropColumn(
                name: "Release_Date",
                table: "Song");

            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Song",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Audio_File",
                table: "Song",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08cfc1d0-af46-4492-b041-3e93e756272b", "AQAAAAIAAYagAAAAEOPnH6jWo5DytXfRZ8pR8tHyjDEx+GncExpDfKeDEmGoqVXogse7/CV+ADclNLCeAQ==", "0d405cd3-be87-4a68-bcb2-483f955bb9d0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "Audio_File",
                table: "Song");

            migrationBuilder.AddColumn<DateTime>(
                name: "Release_Date",
                table: "Song",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ArtistSong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSong", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "059b3360-e596-479c-ad6a-9495d94e675b", "AQAAAAIAAYagAAAAEO/5M62fSuqVNyarAxDLwGzxPUXGAPDeK59zZYRCphkdEdiYPIBho3++n/gOlBJ0QA==", "9987d39e-ef80-4940-a43b-5e6022472827" });
        }
    }
}
