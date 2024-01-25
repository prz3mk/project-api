using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecom.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "DeliveryMethods",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShortName",
                value: "UPS");

            migrationBuilder.UpdateData(
                table: "DeliveryMethods",
                keyColumn: "Id",
                keyValue: 4,
                column: "ShortName",
                value: "DPD");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "ProductPicture" },
                values: new object[,]
                {
                    { 5, 1, "Balenciaga x yeezy x gap hoodie", "Yeezy Gap Hoodie", 320m, "/images/products/gap.png\"" },
                    { 6, 2, "Jordan 1 retro's in collaboration with Fragment", "Jordan 1 Retro High", 2900m, "/images/products/fragment.png\"" },
                    { 7, 1, "Jordan 1's in Black Crimson Tint colorway", "Jordan 1 Retro High", 200m, "/images/products/1s" },
                    { 8, 1, "Classic black&white dunks", "Nike Dunk Low Retro", 100m, "/images/products/whitedunks" },
                    { 9, 1, "Reverse black^&white dunks", "Nike Dunk Low Retro", 190m, "/images/products/dunks1.png" },
                    { 10, 1, "Jordan 1's in collaboration with Travis Scott", "Jordan 1 Retro Low", 700m, "/images/products/dunks2.png" },
                    { 11, 1, "Jordan 1's in collaboration with Travis Scott\"", "Jordan 1 Retro Low", 800m, "/images/products/travis.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "DeliveryMethods",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShortName",
                value: "Aramex");

            migrationBuilder.UpdateData(
                table: "DeliveryMethods",
                keyColumn: "Id",
                keyValue: 4,
                column: "ShortName",
                value: "Jumia");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price", "ProductPicture" },
                values: new object[,]
                {
                    { 1, 1, "P1", "Product_1", 2000m, "https://" },
                    { 2, 2, "P1", "Product_2", 2000m, "https://" },
                    { 3, 1, "P1", "Product_3", 2000m, "https://" }
                });
        }
    }
}
