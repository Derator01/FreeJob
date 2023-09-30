namespace FreeJob.Shared.Models
{
    public class ApplicationUserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }

        public UserType Type { get; set; }

        public enum UserType
        {
            Employee,
            Employer
        }
    }
}