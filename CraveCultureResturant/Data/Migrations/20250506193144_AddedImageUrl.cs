﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CraveCultureResturant.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Prouducts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Prouducts",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://via.placeholder.com/150");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Prouducts");
        }
    }
}
