using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using simple_crud_asp_net_core_web_app_razor.Data;
using simple_crud_asp_net_core_web_app_razor.Model;

namespace simple_crud_asp_net_core_web_app_razor.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> _logger;
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public CreateModel(ILogger<CreateModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty, "The Name cannot exactly match the DisplayOrder.");
            }
            if (ModelState.IsValid)
            {
                await _db.Category.AddAsync(Category);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
