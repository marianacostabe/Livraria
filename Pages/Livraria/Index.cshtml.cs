using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Livraria.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Livraria.Pages.Livraria
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;
        public IndexModel(AppDbContext db)
        {
            _db = db;
        }
        public IList<Livros> LivrosList { get; private set; }

        public async Task OnGetAsync()
        {
            LivrosList = await _db.Livraria.AsNoTracking().ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var livro = await _db.Livraria.FindAsync(id);
            if (livro != null)
            {
                _db.Livraria.Remove(livro);
                await _db.SaveChangesAsync();
            }
            return RedirectToPage();
        }
    }
}