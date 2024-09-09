using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class Onetoone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f0323f6-1946-4446-9084-49bb1f6dfc8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9af3e143-c2cc-4240-a12f-bb38f12d36b2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2172b455-04ac-4569-b4a1-ad24fa1c377b", null, "Admin", "ADMIN" },
                    { "303b2f72-a34b-44b3-b1fa-07f1755bf576", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2172b455-04ac-4569-b4a1-ad24fa1c377b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "303b2f72-a34b-44b3-b1fa-07f1755bf576");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4f0323f6-1946-4446-9084-49bb1f6dfc8a", null, "Admin", "ADMIN" },
                    { "9af3e143-c2cc-4240-a12f-bb38f12d36b2", null, "User", "USER" }
                });
        }
    }
}
