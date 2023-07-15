using BulkyWebRazor_temp.Data;
using BulkyWebRazor_temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<Category> Categories { get; set; }
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
           Categories = _context.Categories.ToList();
        }
    }
}
