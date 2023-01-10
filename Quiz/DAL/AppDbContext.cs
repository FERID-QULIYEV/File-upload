using Microsoft.EntityFrameworkCore;
using Quiz.Models;

namespace Quiz.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category>Categories { get; set; }
    }
}
