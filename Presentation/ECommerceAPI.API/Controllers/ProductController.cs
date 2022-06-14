using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductQueryRepository _productQueryRepository;
        private readonly IProductCommandRepository _productCommandRepository;


        public ProductController(IProductQueryRepository productQueryRepository, IProductCommandRepository productCommandRepository)
        {
            _productQueryRepository = productQueryRepository;
            _productCommandRepository = productCommandRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _productCommandRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Example1", CreatedTime = DateTime.UtcNow, Price = 150, Stock = 10 },
                new() { Id = Guid.NewGuid(), Name = "Example2", CreatedTime = DateTime.UtcNow, Price = 150, Stock = 20 },
                new() { Id = Guid.NewGuid(), Name = "Example3", CreatedTime = DateTime.UtcNow, Price = 150, Stock = 30 }
            });
            await _productCommandRepository.SaveAsync();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productQueryRepository.GetByIdAsync(id);
            return Ok(product);
        }

    }
}
