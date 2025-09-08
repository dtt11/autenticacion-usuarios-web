using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutenticacionWeb.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracionDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1fcce683-9b14-4ff6-a4df-c0069ede227b", "a1", "admin", "ADMIN" },
                    { "48b11774-156f-4f72-bdbe-d15c8ce77d5e", "b1", "vendedor", "VENDEDOR" },
                    { "916302fb-cbca-4f53-9944-2ca963126447", "c1", "cliente", "CLIENTE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fcce683-9b14-4ff6-a4df-c0069ede227b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48b11774-156f-4f72-bdbe-d15c8ce77d5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "916302fb-cbca-4f53-9944-2ca963126447");
        }
    }
}
