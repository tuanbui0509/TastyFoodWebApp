using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyFoodSolution.Application.Catolog.Products;

namespace TastyFoodSolution.BackendApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        public ProductController(IPublicProductService publicProductService)
        
        {
            _publicProductService = publicProductService;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var data = await _publicProductService.GetAll();
            return Ok(data);
        }
    }
}
