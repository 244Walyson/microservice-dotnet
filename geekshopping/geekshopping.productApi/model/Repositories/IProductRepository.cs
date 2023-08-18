using geekshopping.productApi.Data.DTO;

namespace geekshopping.productApi.model.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDTO>> FindAll();
        Task<ProductDTO> FindById(long id);
        Task<ProductDTO> Create(ProductDTO dto);
        Task<ProductDTO> Update(ProductDTO dto);
        Task<bool> DeleteById(long id);
    }
}
