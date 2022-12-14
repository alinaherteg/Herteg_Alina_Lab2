using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Herteg_Alina_Lab2.Data;
using Herteg_Alina_Lab2.Models;

namespace Herteg_Alina_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Herteg_Alina_Lab2.Data.Herteg_Alina_Lab2Context _context;

        public IndexModel(Herteg_Alina_Lab2.Data.Herteg_Alina_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
