using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Test.Models;
using Test.Services;

namespace Test.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IUser _user;

        [BindProperty]
        public UserSubscription UserSubscription { get; set; }

        public IList<UserSubscription> Users { get; set; }
        public IndexModel(IUser user)
        {
            _user = user;
        }

        public void OnGet()
        {
            Users = _user.GetUsers();
        }

        public IActionResult OnPost()
        {
            _user.SaveUser(UserSubscription);

            return RedirectToPage("./Index");
        }
    }
}
