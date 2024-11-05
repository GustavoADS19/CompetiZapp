using Microsoft.AspNetCore.Identity;

namespace CompetiZapp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public bool UseDarkMode { get; set; }
    }

}
