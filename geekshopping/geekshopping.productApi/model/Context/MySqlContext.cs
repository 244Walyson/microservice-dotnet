using Microsoft.EntityFrameworkCore;

namespace geekshopping.productApi.model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() {}
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) {}


        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "name test",
                Price = 33.22, // Use decimal "m" suffix for the price
                Description = "desc test",
                imgUrl = "imurl.com.test", // Use "ImgUrl" with capital "I"
                CategoryName = "test category"
            });
        }

    }
}
