using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly ICostumerWriteRepository _costumerWriteRepository;
        private IOrderReadRepository _orderReadRepository;

        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteRepository, ICostumerWriteRepository costumerWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _costumerWriteRepository = costumerWriteRepository;
            _orderReadRepository = orderReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //var costumerId = Guid.NewGuid();
            //await _costumerWriteRepository.AddAsync(new() { Id = costumerId, Name = "gggg" });

            //await _orderWriteRepository.AddAsync(new() { Descripton = "aa", Address="bb" });
            //await _orderWriteRepository.AddAsync(new() { Descripton = "cc", Address="dd" });
            //await _orderWriteRepository.AddAsync(new() { Descripton = "ee", Address="ff" });
            Order order = await _orderReadRepository.GetByIdAsync("");
            order.Address = "kayseri";
            await _orderWriteRepository.SaveChangesAsync();
        }
    }
}
