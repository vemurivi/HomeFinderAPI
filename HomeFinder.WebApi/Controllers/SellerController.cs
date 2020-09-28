using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HomeFinder.Services.Contracts;
using HomeFinder.Services.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeFinder.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : Controller
    {
        private ISellerService _sellerService { get; set; }
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        public SellerController(ISellerService sellerService, IMapper mapper, ILogger<SellerController> logger)
        {
            _sellerService = sellerService;
            _mapper = mapper;
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Seller seller)
        {
            try
            {
                var entity = _mapper.Map<Seller>(seller);
                var item = await _sellerService.Create(entity);
                return CreatedAtRoute("GetSellers", new { Controller = "Seller", id = seller.SellerId }, seller);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Read(long id)
        {
            try
            {
                var seller = await _sellerService.Read(id);
                return Ok(seller);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
            
        }
        [HttpPatch]
        public async Task<IActionResult> Update([FromBody] Seller seller)
        {
            try
            {
                var entity = _mapper.Map<Seller>(seller);
                var item = await _sellerService.Update(entity);
                return NoContent();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
            
        }

    }
}
