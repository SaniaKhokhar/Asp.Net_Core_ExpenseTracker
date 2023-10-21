using Microsoft.AspNetCore.Identity;

namespace Expense_Tracker.Models
{
    public class ApplicationUsers : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
