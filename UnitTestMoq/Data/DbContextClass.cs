using Microsoft.EntityFrameworkCore;
using UnitTestMoq.Model;

namespace UnitTestMoq.Data
{
    public class DbContextClass : DbContext

    {
        public DbContextClass(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
