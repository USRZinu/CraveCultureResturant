using CraveCultureResturant.Data;
using Microsoft.AspNetCore.Http;
using CraveCultureResturant.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CraveCultureResturant.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        private Repository<Product> _products;
        private Repository<Order> _orders;
        private readonly UserManager<ApplicationUser> _userManager;

        public OrderController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            _products = new Repository<Product>(context);
            _orders = new Repository<Order>(context);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            // Split the complex statement into simpler steps to avoid ENC0046
            var sessionModel = HttpContext.Session.Get<OrderViewModel>("OrderViewModel");
            var products = await _products.GetAllAsync();

            var model = sessionModel ?? new OrderViewModel
            {
                OrderItems = new List<OrderItemViewModel>(),
                Products = products
            };

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddItem(int prodId, int prodQty)
        {
            var product = await _context.Prouducts.FindAsync(prodId);
            if (product == null)
            {
                return NotFound();
            }

            // Split the complex statement into simpler steps to avoid ENC0046
            var sessionModel = HttpContext.Session.Get<OrderViewModel>("OrderViewModel");
            var products = await _products.GetAllAsync();

            var model = sessionModel ?? new OrderViewModel
            {
                OrderItems = new List<OrderItemViewModel>(),
                Products = products
            };

            // Check if the product is already in the order
            var existingItem = model.OrderItems.FirstOrDefault(oi => oi.ProductId == prodId);

            // If the product is already in the order, update the quantity
            if (existingItem != null)
            {
                existingItem.Quantity += prodQty;
            }
            else
            {
                model.OrderItems.Add(new OrderItemViewModel
                {
                    ProductId = product.ProductId,
                    Price = product.Price,
                    Quantity = prodQty,
                    ProductName = product.Name
                });
            }

            // Update the total amount
            model.TotalAmount = model.OrderItems.Sum(oi => oi.Price * oi.Quantity);

            // Save updated OrderViewModel to session
            HttpContext.Session.Set("OrderViewModel", model);

            // Redirect back to Create to show updated order items
            return RedirectToAction("Create", model);
        }
    }
}