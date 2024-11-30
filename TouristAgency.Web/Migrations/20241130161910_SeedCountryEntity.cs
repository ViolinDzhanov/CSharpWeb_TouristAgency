using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TouristAgency.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedCountryEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("360218ce-abbb-4ddf-a0d3-0900dab63843"), "Greece" },
                    { new Guid("8a7ab379-4ccd-43b6-a9b3-7c22bb5d9f11"), "Italy" },
                    { new Guid("d225932b-e49b-4f30-89a3-a1863c6857f6"), "Bulgaria" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("360218ce-abbb-4ddf-a0d3-0900dab63843"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8a7ab379-4ccd-43b6-a9b3-7c22bb5d9f11"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d225932b-e49b-4f30-89a3-a1863c6857f6"));
        }
    }
}
