using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FreeJob.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "261e9cd0-68b5-4823-9d43-95f8f6a2ddba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3d78a50-8bed-417c-9c42-eb12172bf8ac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "014c370f-641a-48b8-aec8-2e6630ad395a", "6a069e37-2b0f-43db-b923-f3087b16b77f", "Employee", "EMPLOYEE" },
                    { "ec8e5f94-b800-416e-b438-28f3c5195bbf", "4ffe20b1-d6c0-4fa3-9572-ab00ebf55f5d", "Employer", "EMPLOYER" },
                    { "eee538b4-7a0a-4f06-bcc1-50a0fbbb0a79", "72cf8818-421c-457f-beb5-297bdb19cf35", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "014c370f-641a-48b8-aec8-2e6630ad395a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec8e5f94-b800-416e-b438-28f3c5195bbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eee538b4-7a0a-4f06-bcc1-50a0fbbb0a79");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "261e9cd0-68b5-4823-9d43-95f8f6a2ddba", "163d775b-582a-4de5-82a2-b49a05f6222d", "Employer", "EMPLOYER" },
                    { "e3d78a50-8bed-417c-9c42-eb12172bf8ac", "25fa7555-c63f-46d9-9c55-fc471ec7576e", "Employee", "EMPLOYEE" }
                });
        }
    }
}
