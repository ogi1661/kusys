using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestProje.API.DTOs;
using TestProje.Core.Services;

namespace TestProje.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;



        public ProductsController(IProductService producService, IMapper mapper)
        {
            _productService = producService;
            _mapper = mapper;
        }


        public async Task<IActionResult> GetAll()
        {
            var categories = await _productService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<ProductDto>>(categories));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            return Ok(_mapper.Map<ProductDto>(product));
        }



    }
}
