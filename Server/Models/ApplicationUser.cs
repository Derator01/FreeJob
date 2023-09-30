using Microsoft.AspNetCore.Identity;

namespace FreeJob.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public UserType Type { get; set; }

        public enum UserType
        {
            Employee,
            Employer
        }
    }
}