using Microsoft.AspNetCore.Identity;

namespace Film.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
