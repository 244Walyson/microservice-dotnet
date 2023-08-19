using geekshopping.productApi.Data.DTO;

namespace geekshopping.Services.IServices
{
    public interface IProductService
    {

        Task<IEnumerable<ProductModel>> FindAllProducts();
        Task<ProductModel> FindById(long id);
        Task<ProductModel> Create(ProductModel productModel);
        Task<ProductModel> Update(ProductModel productModel);
        Task<bool> DeleteById(long id);

    }
}
