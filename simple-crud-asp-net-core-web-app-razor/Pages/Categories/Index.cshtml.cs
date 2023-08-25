using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using simple_crud_asp_net_core_web_app_razor.Data;
using simple_crud_asp_net_core_web_app_razor.Model;

namespace simple_crud_asp_net_core_web_app_razor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _db;
        public IEnumerable<Category> Categories { get; set; }
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public void OnGet()
        {
            Categories = _db.Category;
        }
    }
}
