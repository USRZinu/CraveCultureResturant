using Microsoft.AspNetCore.Identity;

namespace CraveCultureResturant.Models
{
    public class ApplicationUser :IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}
