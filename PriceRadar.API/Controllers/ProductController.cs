using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PriceRadar.Application.Interfaces;

namespace PriceRadar.API.Controllers
{
    [Route("api/tracking")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, ILogger<ProductController> logger, IMapper mapper)
        {
            _productService = productService;
            _logger = logger;
            _mapper = mapper;
        }
    }
}
