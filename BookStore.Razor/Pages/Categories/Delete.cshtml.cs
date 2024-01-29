using BookStore.Razor.Data;
using BookStore.Razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore.Razor.Pages.Categories
{
	[BindProperties]
    public class DeleteModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		public Category? Category { get; set; }

		public DeleteModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet(int? Id)
        {
			if (Id != null && Id != 0)
			{
				Category = _db.Categories.Find(Id);
			}
        }
		public IActionResult OnPost(int? Id) 
		{
			Category? obj = _db.Categories.Find(Category.Id);
			if (obj == null)
			{
				return NotFound();
			}
			_db.Categories.Remove(obj);
			_db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToPage("Index");
		}
    }
}
