using Microsoft.AspNetCore.Identity;
using static FreeJob.Shared.Models.ApplicationUserModel;

namespace FreeJob.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public UserType Type { get; set; }
    }
}