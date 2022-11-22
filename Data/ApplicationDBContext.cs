using Microsoft.EntityFrameworkCore;
using RazorPagesBase.Model;

namespace RazorPagesBase.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {

        }
    
        public DbSet<Category> Category { get; set; }
    }
}
