using Microsoft.AspNetCore.Identity;

namespace SMOP.Data.Userdata
{
    public class ApplicationUser : IdentityUser
    {
        public long id;
        public string firstName;
        public string lastName;
        public string patronymic;
        public string phone;
        public string email;
    }
}
