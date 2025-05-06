using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CraveCultureResturant.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Prouducts",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prouducts", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Prouducts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Prouducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Prouducts",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductIngredients",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductIngredients", x => new { x.ProductId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_ProductIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductIngredients_Prouducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Prouducts",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Appetizer" },
                    { 2, "Entree" },
                    { 3, "Side Dish" },
                    { 4, "Dessert" },
                    { 5, "Beverage" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "Name" },
                values: new object[,]
                {
                    { 1, "Chicken" },
                    { 2, "Beef" },
                    { 3, "Fish" },
                    { 4, "Vegetable" },
                    { 5, "Rice" },
                    { 6, "Pasta" },
                    { 7, "Salad" },
                    { 8, "Sauce" }
                });

            migrationBuilder.InsertData(
                table: "Prouducts",
                columns: new[] { "ProductId", "CategoryId", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 2, "Crispy rolls filled with vegetables", "Spring Rolls", 2.50m, 100 },
                    { 2, 1, "Spicy chicken curry with rice", "Chicken Curry", 10.00m, 50 },
                    { 3, 2, "Tender beef stir fry with vegetables", "Beef Stir Fry", 12.00m, 30 },
                    { 4, 3, "Fried rice with mixed vegetables", "Vegetable Fried Rice", 8.00m, 20 },
                    { 5, 4, "Rich chocolate cake with frosting", "Chocolate Cake", 5.00m, 15 },
                    { 6, 3, "Fresh salad with Caesar dressing", "Caesar Salad", 6.00m, 25 },
                    { 7, 2, "Grilled salmon with lemon butter sauce", "Grilled Salmon", 15.00m, 10 },
                    { 8, 5, "Sweet mango yogurt drink", "Mango Lassi", 3.00m, 40 },
                    { 9, 2, "Pasta with mixed vegetables", "Pasta Primavera", 9.00m, 35 },
                    { 10, 4, "Italian coffee-flavored dessert", "Tiramisu", 7.00m, 20 },
                    { 11, 1, "Spicy vegetable-filled pastry", "Vegetable Samosa", 3.00m, 50 },
                    { 12, 2, "Grilled chicken in creamy tomato sauce", "Chicken Tikka Masala", 11.00m, 40 },
                    { 13, 3, "Soft Indian bread with garlic", "Garlic Naan", 2.00m, 60 },
                    { 14, 4, "Creamy cheesecake with graham cracker crust", "Cheesecake", 6.00m, 30 },
                    { 15, 5, "Refreshing iced tea with lemon", "Iced Tea", 2.50m, 70 },
                    { 16, 2, "Mixed vegetables stir-fried with soy sauce", "Vegetable Stir Fry", 7.00m, 45 },
                    { 17, 3, "Fresh seasonal fruit salad", "Fruit Salad", 4.00m, 55 },
                    { 18, 4, "Light and airy chocolate dessert", "Chocolate Mousse", 5.00m, 25 }
                });

            migrationBuilder.InsertData(
                table: "ProductIngredients",
                columns: new[] { "IngredientId", "ProductId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 4, 4 },
                    { 8, 5 },
                    { 4, 6 },
                    { 3, 7 },
                    { 1, 8 },
                    { 4, 9 },
                    { 8, 10 },
                    { 4, 11 },
                    { 1, 12 },
                    { 4, 13 },
                    { 8, 14 },
                    { 1, 15 },
                    { 4, 16 },
                    { 4, 17 },
                    { 8, 18 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductIngredients_IngredientId",
                table: "ProductIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Prouducts_CategoryId",
                table: "Prouducts",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductIngredients");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Prouducts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
