using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webapi.MyDbContext;

namespace webapi.Pages
{
    public class UserDatabaseViewModel : PageModel
    {
        private readonly webapi.MyDbContext.MyUserContext _context;

        public UserDatabaseViewModel(webapi.MyDbContext.MyUserContext context)
        {
            _context = context;
        }

        public IList<MyUser> MyUser { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Users != null)
            {
                MyUser = await _context.Users.ToListAsync();
            }
        }
    }
}
