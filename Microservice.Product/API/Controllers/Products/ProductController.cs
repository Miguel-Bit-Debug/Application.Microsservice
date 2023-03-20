using AutoMapper;
using Domain.DTOs.Request;
using Domain.Interfaces.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Products
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public ProductController(IMapper mapper,
                                 IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        [HttpPost("add-product")]
        public async Task<IActionResult> AddProduct([FromBody] ProductRequest request)
        {
            var  product = _mapper.Map<Product>(request);

            var result = await _productService.AddProduct(product);

            if(!result)
            {
                return BadRequest("Erro ao tentar adicionar produto.");
            }

            return Ok(product);
        }

        [HttpGet("list-products")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProducts();

            return Ok(products);
        }
    }
}
