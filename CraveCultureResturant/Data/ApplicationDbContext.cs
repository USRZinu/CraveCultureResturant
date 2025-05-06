using CraveCultureResturant.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CraveCultureResturant.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Prouducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<ProductIngredient> ProductIngredients { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure the composite key for ProductIngredient
            modelBuilder.Entity<ProductIngredient>()
                .HasKey(pi => new { pi.ProductId, pi.IngredientId });
            // Configure the many-to-many relationship between Product and Ingredient
            modelBuilder.Entity<ProductIngredient>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductsIngredients)
                .HasForeignKey(pi => pi.ProductId);
            modelBuilder.Entity<ProductIngredient>()
                .HasOne(pi => pi.Ingredient)
                .WithMany(i => i.ProductIngredients)
                .HasForeignKey(pi => pi.IngredientId);
            //See Data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Appetizer" },
                new Category { CategoryId = 2,Name="Entree" },
                new Category { CategoryId = 3, Name = "Side Dish" },
                new Category { CategoryId = 4, Name = "Dessert" },
                new Category { CategoryId = 5, Name = "Beverage" }
            );
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientId = 1, Name = "Chicken" },
                new Ingredient { IngredientId = 2, Name = "Beef" },
                new Ingredient { IngredientId = 3, Name = "Fish" },
                new Ingredient { IngredientId = 4, Name = "Vegetable" },
                new Ingredient { IngredientId = 5, Name = "Rice" },
                new Ingredient { IngredientId = 6, Name = "Pasta" },
                new Ingredient { IngredientId = 7, Name = "Salad" },
                new Ingredient { IngredientId = 8, Name = "Sauce" }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                { ProductId=1,
                    Name = "Spring Rolls",
                    Description = "Crispy rolls filled with vegetables",
                    Price = 2.50m,
                    Stock = 100,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Chicken Curry",
                    Description = "Spicy chicken curry with rice",
                    Price = 10.00m,
                    Stock = 50,
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Beef Stir Fry",
                    Description = "Tender beef stir fry with vegetables",
                    Price = 12.00m,
                    Stock = 30,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Vegetable Fried Rice",
                    Description = "Fried rice with mixed vegetables",
                    Price = 8.00m,
                    Stock = 20,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Chocolate Cake",
                    Description = "Rich chocolate cake with frosting",
                    Price = 5.00m,
                    Stock = 15,
                    CategoryId = 4
                },
                new Product
                {
                    ProductId = 6,
                    Name = "Caesar Salad",
                    Description = "Fresh salad with Caesar dressing",
                    Price = 6.00m,
                    Stock = 25,
                    CategoryId = 3
                },
                new Product
                {
                    ProductId = 7,
                    Name = "Grilled Salmon",
                    Description = "Grilled salmon with lemon butter sauce",
                    Price = 15.00m,
                    Stock = 10,
                    CategoryId = 2
                },
                new Product
                {
                    ProductId = 8,
                    Name = "Mango Lassi",
                    Description = "Sweet mango yogurt drink",
                    Price = 3.00m,
                    Stock = 40,
                    CategoryId = 5
                },
                new Product
                {
                    ProductId = 9,
                    Name = "Pasta Primavera",
                    Description = "Pasta with mixed vegetables",
                    Price = 9.00m,
                    Stock = 35,
                    CategoryId = 2
                },
                   new Product
                   {
                       ProductId = 10,
                       Name = "Tiramisu",
                       Description = "Italian coffee-flavored dessert",
                       Price = 7.00m,
                       Stock = 20,
                       CategoryId = 4
                   },
                   new Product
                   {
                       ProductId = 11,
                       Name = "Vegetable Samosa",
                       Description = "Spicy vegetable-filled pastry",
                       Price = 3.00m,
                       Stock = 50,
                       CategoryId = 1
                   },
                     new Product
                     {
                         ProductId = 12,
                         Name = "Chicken Tikka Masala",
                         Description = "Grilled chicken in creamy tomato sauce",
                         Price = 11.00m,
                         Stock = 40,
                         CategoryId = 2
                     },
                        new Product
                        {
                            ProductId = 13,
                            Name = "Garlic Naan",
                            Description = "Soft Indian bread with garlic",
                            Price = 2.00m,
                            Stock = 60,
                            CategoryId = 3
                        },
                        new Product
                        {
                            ProductId = 14,
                            Name = "Cheesecake",
                            Description = "Creamy cheesecake with graham cracker crust",
                            Price = 6.00m,
                            Stock = 30,
                            CategoryId = 4
                        },
                        new Product
                        {
                            ProductId = 15,
                            Name = "Iced Tea",
                            Description = "Refreshing iced tea with lemon",
                            Price = 2.50m,
                            Stock = 70,
                            CategoryId = 5
                        },
                        new Product
                        {
                            ProductId = 16,
                            Name = "Vegetable Stir Fry",
                            Description = "Mixed vegetables stir-fried with soy sauce",
                            Price = 7.00m,
                            Stock = 45,
                            CategoryId = 2
                        },
                        new Product
                        {
                            ProductId = 17,
                            Name = "Fruit Salad",
                            Description = "Fresh seasonal fruit salad",
                            Price = 4.00m,
                            Stock = 55,
                            CategoryId = 3
                        },
                        new Product
                        {
                            ProductId = 18,
                            Name = "Chocolate Mousse",
                            Description = "Light and airy chocolate dessert",
                            Price = 5.00m,
                            Stock = 25,
                            CategoryId = 4
                        }
                   );
            modelBuilder.Entity<ProductIngredient>().HasData(
                new ProductIngredient { ProductId = 1, IngredientId = 4 },
                new ProductIngredient { ProductId = 2, IngredientId = 1 },
                new ProductIngredient { ProductId = 3, IngredientId = 2 },
                new ProductIngredient { ProductId = 4, IngredientId = 4 },
                new ProductIngredient { ProductId = 5, IngredientId = 8 },
                new ProductIngredient { ProductId = 6, IngredientId = 4 },
                new ProductIngredient { ProductId = 7, IngredientId = 3 },
                new ProductIngredient { ProductId = 8, IngredientId = 1 },
                new ProductIngredient { ProductId = 9, IngredientId = 4 },
                new ProductIngredient { ProductId = 10, IngredientId = 8 },
                new ProductIngredient { ProductId = 11, IngredientId = 4 },
                new ProductIngredient { ProductId = 12, IngredientId = 1 },
                new ProductIngredient { ProductId = 13, IngredientId = 4 },
                new ProductIngredient { ProductId = 14, IngredientId = 8 },
                new ProductIngredient { ProductId = 15, IngredientId = 1 },
                new ProductIngredient { ProductId = 16, IngredientId = 4 },
                new ProductIngredient { ProductId = 17, IngredientId = 4 },
                new ProductIngredient { ProductId = 18, IngredientId = 8 }
            );



        }
    }

    }

