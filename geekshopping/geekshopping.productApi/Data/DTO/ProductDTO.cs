namespace geekshopping.productApi.Data.DTO
{
    public class ProductDTO
    {
        public long Id { get; set; }
        public string Name { get; set; } 
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string imgUrl { get; set; }
    }
}
