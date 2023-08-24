using Microsoft.EntityFrameworkCore;
using simple_crud_asp_net_core_web_app_razor.Model;

namespace simple_crud_asp_net_core_web_app_razor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
    }
}
