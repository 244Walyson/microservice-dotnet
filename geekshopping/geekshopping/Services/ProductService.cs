using geekshopping.productApi.Data.DTO;
using geekshopping.Services.IServices;
using geekshopping.Utils;

namespace geekshopping.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        public const string BasePath = "api/v1/Product";

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<ProductModel> Create(ProductModel productModel)
        {
            var response = await _httpClient.PostJson(BasePath, productModel);
            if (response.IsSuccessStatusCode) return await response.ReadContentAs<ProductModel>();
            else throw new Exception("something went wrong when calling API");
        }

        public Task<bool> DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductModel>> FindAllProducts()
        {
            var response = await _httpClient.GetAsync(BasePath);
            return await response.ReadContentAs<List<ProductModel>>();
        }

        public async Task<ProductModel> FindById(long id)
        {
            var response = await _httpClient.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ProductModel>();
        }

        public async Task<ProductModel> Update(ProductModel productModel)
        {
            var response = await _httpClient.PutJson(BasePath, productModel);
            if(response.IsSuccessStatusCode) return await response.ReadContentAs<ProductModel>();
            else throw new Exception("something went wrong when calling API");
        }
    }
}
