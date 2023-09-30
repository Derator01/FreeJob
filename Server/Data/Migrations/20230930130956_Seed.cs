using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FreeJob.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "261e9cd0-68b5-4823-9d43-95f8f6a2ddba", "163d775b-582a-4de5-82a2-b49a05f6222d", "Employer", "EMPLOYER" },
                    { "e3d78a50-8bed-417c-9c42-eb12172bf8ac", "25fa7555-c63f-46d9-9c55-fc471ec7576e", "Employee", "EMPLOYEE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "261e9cd0-68b5-4823-9d43-95f8f6a2ddba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3d78a50-8bed-417c-9c42-eb12172bf8ac");
        }
    }
}
