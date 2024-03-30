using GetProductAPI.Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetProductAPIController : ControllerBase
    {
        private readonly IProductService _productService;

        public GetProductAPIController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }
    }
}
