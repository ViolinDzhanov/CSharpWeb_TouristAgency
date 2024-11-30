using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TouristAgency.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedTownsEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DeleteData(
            //    table: "Countries",
            //    keyColumn: "Id",
            //    keyValue: new Guid("4eeebc4f-36ea-4a09-87c3-e9aa4c0838a0"));

            //migrationBuilder.DeleteData(
            //    table: "Countries",
            //    keyColumn: "Id",
            //    keyValue: new Guid("dcc476b4-71e9-4b5c-9611-931561b63d2a"));

            //migrationBuilder.DeleteData(
            //    table: "Countries",
            //    keyColumn: "Id",
            //    keyValue: new Guid("f2f647d5-74b3-483f-b100-0ad873462ae1"));

            //migrationBuilder.DeleteData(
            //    table: "Towns",
            //    keyColumn: "Id",
            //    keyValue: new Guid("0a84cebd-2ecd-4ccf-acab-676cfdbe8ab4"));

            //migrationBuilder.DeleteData(
            //    table: "Towns",
            //    keyColumn: "Id",
            //    keyValue: new Guid("31405159-4b0f-4e96-9860-bc8605582acc"));

            //migrationBuilder.DeleteData(
            //    table: "Towns",
            //    keyColumn: "Id",
            //    keyValue: new Guid("32e9ef79-3253-49b0-a04e-586a6af7cde1"));

            //migrationBuilder.DeleteData(
            //    table: "Towns",
            //    keyColumn: "Id",
            //    keyValue: new Guid("4ef19c48-08c9-44df-883e-fe1cd764a7b5"));

            //migrationBuilder.DeleteData(
            //    table: "Towns",
            //    keyColumn: "Id",
            //    keyValue: new Guid("50557c08-4561-45e0-a5c8-19a39ec2f007"));

            //migrationBuilder.DeleteData(
            //    table: "Towns",
            //    keyColumn: "Id",
            //    keyValue: new Guid("89620ad7-f499-4c69-b4e2-5ff15d31889b"));

            //migrationBuilder.DeleteData(
            //    table: "Towns",
            //    keyColumn: "Id",
            //    keyValue: new Guid("c90656b0-b160-4cc2-b8ea-8a6a83fa70e6"));

            //migrationBuilder.DeleteData(
            //    table: "Towns",
            //    keyColumn: "Id",
            //    keyValue: new Guid("da191dec-09d4-4b58-a1e7-4c0ffe2e74c8"));

            //migrationBuilder.DeleteData(
            //    table: "Towns",
            //    keyColumn: "Id",
            //    keyValue: new Guid("ffbb1ad5-d5bb-4528-91b9-ccaf5abeb9cc"));

            //migrationBuilder.InsertData(
            //    table: "Countries",
            //    columns: new[] { "Id", "Name" },
            //    values: new object[,]
            //    {
            //        { new Guid("63eaa539-c251-48f0-a4c6-6b05974bd08d"), "Greece" },
            //        { new Guid("723b0d89-c511-45f1-b42a-2e4b9ea64885"), "Italy" },
            //        { new Guid("f05400a5-1b5e-48af-b770-4fe41a045335"), "Bulgaria" }
            //    });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { new Guid("11d990df-1826-473b-b7aa-90b75692057f"), new Guid("d225932b-e49b-4f30-89a3-a1863c6857f6"), "Varna" },
                    { new Guid("1dc6be30-98d1-44d6-bab4-a41456d29a89"), new Guid("8a7ab379-4ccd-43b6-a9b3-7c22bb5d9f11"), "Venice" },
                    { new Guid("22a306f1-82b9-4b3c-98f3-45bef82323ef"), new Guid("8a7ab379-4ccd-43b6-a9b3-7c22bb5d9f11"), "Milan" },
                    { new Guid("363da011-b42d-47bf-a96a-b73b555b845f"), new Guid("360218ce-abbb-4ddf-a0d3-0900dab63843"), "Patras" },
                    { new Guid("59fb5adf-4f0c-4be8-8c95-e8e39c88f440"), new Guid("360218ce-abbb-4ddf-a0d3-0900dab63843"), "Athens" },
                    { new Guid("64426a37-b3bd-49c6-9172-d288f108d63d"), new Guid("d225932b-e49b-4f30-89a3-a1863c6857f6"), "Plovdiv" },
                    { new Guid("7366dcf6-962d-4ad0-890f-d425668a1076"), new Guid("8a7ab379-4ccd-43b6-a9b3-7c22bb5d9f11"), "Rome" },
                    { new Guid("8bd2d44c-8022-4eac-a96b-e0dac18f1c21"), new Guid("360218ce-abbb-4ddf-a0d3-0900dab63843"), "Thessaloniki" },
                    { new Guid("cd11f2e1-cb7e-4798-b5a7-14137d47b5f1"), new Guid("d225932b-e49b-4f30-89a3-a1863c6857f6"), "Sofia" }
                });
        }

        /// <inheritdoc />
        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DeleteData(
        //        table: "Countries",
        //        keyColumn: "Id",
        //        keyValue: new Guid("63eaa539-c251-48f0-a4c6-6b05974bd08d"));

        //    migrationBuilder.DeleteData(
        //        table: "Countries",
        //        keyColumn: "Id",
        //        keyValue: new Guid("723b0d89-c511-45f1-b42a-2e4b9ea64885"));

        //    migrationBuilder.DeleteData(
        //        table: "Countries",
        //        keyColumn: "Id",
        //        keyValue: new Guid("f05400a5-1b5e-48af-b770-4fe41a045335"));

        //    migrationBuilder.DeleteData(
        //        table: "Towns",
        //        keyColumn: "Id",
        //        keyValue: new Guid("11d990df-1826-473b-b7aa-90b75692057f"));

        //    migrationBuilder.DeleteData(
        //        table: "Towns",
        //        keyColumn: "Id",
        //        keyValue: new Guid("1dc6be30-98d1-44d6-bab4-a41456d29a89"));

        //    migrationBuilder.DeleteData(
        //        table: "Towns",
        //        keyColumn: "Id",
        //        keyValue: new Guid("22a306f1-82b9-4b3c-98f3-45bef82323ef"));

        //    migrationBuilder.DeleteData(
        //        table: "Towns",
        //        keyColumn: "Id",
        //        keyValue: new Guid("363da011-b42d-47bf-a96a-b73b555b845f"));

        //    migrationBuilder.DeleteData(
        //        table: "Towns",
        //        keyColumn: "Id",
        //        keyValue: new Guid("59fb5adf-4f0c-4be8-8c95-e8e39c88f440"));

        //    migrationBuilder.DeleteData(
        //        table: "Towns",
        //        keyColumn: "Id",
        //        keyValue: new Guid("64426a37-b3bd-49c6-9172-d288f108d63d"));

        //    migrationBuilder.DeleteData(
        //        table: "Towns",
        //        keyColumn: "Id",
        //        keyValue: new Guid("7366dcf6-962d-4ad0-890f-d425668a1076"));

        //    migrationBuilder.DeleteData(
        //        table: "Towns",
        //        keyColumn: "Id",
        //        keyValue: new Guid("8bd2d44c-8022-4eac-a96b-e0dac18f1c21"));

        //    migrationBuilder.DeleteData(
        //        table: "Towns",
        //        keyColumn: "Id",
        //        keyValue: new Guid("cd11f2e1-cb7e-4798-b5a7-14137d47b5f1"));

        //    migrationBuilder.InsertData(
        //        table: "Countries",
        //        columns: new[] { "Id", "Name" },
        //        values: new object[,]
        //        {
        //            { new Guid("4eeebc4f-36ea-4a09-87c3-e9aa4c0838a0"), "Italy" },
        //            { new Guid("dcc476b4-71e9-4b5c-9611-931561b63d2a"), "Greece" },
        //            { new Guid("f2f647d5-74b3-483f-b100-0ad873462ae1"), "Bulgaria" }
        //        });

        //    migrationBuilder.InsertData(
        //        table: "Towns",
        //        columns: new[] { "Id", "CountryId", "Name" },
        //        values: new object[,]
        //        {
        //            { new Guid("0a84cebd-2ecd-4ccf-acab-676cfdbe8ab4"), new Guid("8a7ab379-4ccd-43b6-a9b3-7c22bb5d9f11"), "Milan" },
        //            { new Guid("31405159-4b0f-4e96-9860-bc8605582acc"), new Guid("8a7ab379-4ccd-43b6-a9b3-7c22bb5d9f11"), "Venice" },
        //            { new Guid("32e9ef79-3253-49b0-a04e-586a6af7cde1"), new Guid("360218ce-abbb-4ddf-a0d3-0900dab63843"), "Athens" },
        //            { new Guid("4ef19c48-08c9-44df-883e-fe1cd764a7b5"), new Guid("d225932b-e49b-4f30-89a3-a1863c6857f6"), "Varna" },
        //            { new Guid("50557c08-4561-45e0-a5c8-19a39ec2f007"), new Guid("d225932b-e49b-4f30-89a3-a1863c6857f6"), "Plovdiv" },
        //            { new Guid("89620ad7-f499-4c69-b4e2-5ff15d31889b"), new Guid("8a7ab379-4ccd-43b6-a9b3-7c22bb5d9f11"), "Rome" },
        //            { new Guid("c90656b0-b160-4cc2-b8ea-8a6a83fa70e6"), new Guid("360218ce-abbb-4ddf-a0d3-0900dab63843"), "Thessaloniki" },
        //            { new Guid("da191dec-09d4-4b58-a1e7-4c0ffe2e74c8"), new Guid("d225932b-e49b-4f30-89a3-a1863c6857f6"), "Sofia" },
        //            { new Guid("ffbb1ad5-d5bb-4528-91b9-ccaf5abeb9cc"), new Guid("360218ce-abbb-4ddf-a0d3-0900dab63843"), "Patras" }
        //        });
        //}
    }
}
