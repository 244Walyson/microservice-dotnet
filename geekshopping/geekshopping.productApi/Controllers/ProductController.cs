using geekshopping.productApi.Data.DTO;
using geekshopping.productApi.model;
using geekshopping.productApi.model.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace geekshopping.productApi.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> FindById(long id)
        {
            var product = await _repository.FindById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> FindAll()
        {
            var products = await _repository.FindAll();
            if (products == null)
                return NotFound();
            return Ok(products);
        }


        [HttpPost]
        public async Task<ActionResult<ProductDTO>> insert(ProductDTO dto)
        {
            if(dto == null)
            {
                return BadRequest();
            }
            dto = await _repository.Create(dto);
            return Ok(dto);
        }

        [HttpDelete("id")]
        public async Task<ActionResult> delete(long id)
        {
            _repository.DeleteById(id);
            return NoContent();
        }
    }
}
