using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CraveCultureResturant.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Price",
                value: 70.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Price",
                value: 150.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Price",
                value: 250.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "Price",
                value: 165.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Price",
                value: 100.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "Price",
                value: 170.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "Price",
                value: 315.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "Price",
                value: 150.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "Price",
                value: 200.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Price",
                value: 265.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "Price",
                value: 10.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "Price",
                value: 245.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "Price",
                value: 80.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "Price",
                value: 190.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "Price",
                value: 45.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "Price",
                value: 160.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "Price",
                value: 120.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "Price",
                value: 95.00m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Price",
                value: 2.50m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Price",
                value: 10.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Price",
                value: 12.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "Price",
                value: 8.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Price",
                value: 5.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "Price",
                value: 6.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "Price",
                value: 15.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "Price",
                value: 3.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "Price",
                value: 9.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Price",
                value: 7.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "Price",
                value: 3.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "Price",
                value: 11.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "Price",
                value: 2.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "Price",
                value: 6.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "Price",
                value: 2.50m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "Price",
                value: 7.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "Price",
                value: 4.00m);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "Price",
                value: 5.00m);
        }
    }
}
