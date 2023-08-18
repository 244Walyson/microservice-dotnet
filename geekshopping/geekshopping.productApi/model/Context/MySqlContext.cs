using Microsoft.EntityFrameworkCore;

namespace geekshopping.productApi.model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() {}
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) {}


        public DbSet<Product> Products { get; set; }
    }
}
