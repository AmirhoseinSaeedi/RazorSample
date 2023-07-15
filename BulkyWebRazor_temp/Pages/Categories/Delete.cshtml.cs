using BulkyWebRazor_temp.Data;
using BulkyWebRazor_temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_temp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public Category? Category { get; set; }
        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet(int? id)
        {
            Category =_context.Categories.Find(id);
        }
        public IActionResult OnPost(int? id ) {
            
            Category obj = _context.Categories.Find(Category.Id);
            if (obj == null) {
                return Page();
            }
            _context.Categories.Remove(obj);
            _context.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToPage("Index");
        
        }
    }
}
