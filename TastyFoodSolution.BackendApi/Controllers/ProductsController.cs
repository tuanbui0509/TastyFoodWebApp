using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyFoodSolution.Application.Catolog.Products;
using TastyFoodSolution.ViewModels.Catalog.ProductImage;
using TastyFoodSolution.ViewModels.Catalog.Products;
using TastyFoodSolution.ViewModels.Catolog.Products;

namespace TastyFoodSolution.BackendApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllByCategoryId([FromQuery] int categoryId)
        {
            var products = await _productService.GetAllByCategoryId(categoryId);
            return Ok(products);
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetAllProduct()
        {
            var products = await _productService.GetAllProduct();
            return Ok(products);
        }

        [HttpGet("{productId}")]
        [AllowAnonymous]
        public async Task<ActionResult> GetById(int productId)
        {
            var product = await _productService.GetById(productId);
            if (product == null)
                return BadRequest("Cannot find product");
            return Ok(product);
        }

        [HttpPost]
        //[Route("Upload")]
        public async Task<ActionResult> Create([FromBody] ProductCreateRequest request)
        {
            var productId = await _productService.Create(request);
            if (productId == 0)
                return BadRequest();

            var product = await _productService.GetById(productId);

            return CreatedAtAction(nameof(GetById), new { id = productId }, product);
        }

        [HttpGet("featured/{take}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetFeaturedProducts(int take)
        {
            var products = await _productService.GetFeaturedProducts(take);
            return Ok(products);
        }

        [HttpGet("latest/{take}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetLatestProducts(int take)
        {
            var products = await _productService.GetLatestProducts(take);
            return Ok(products);
        }

        [HttpGet("best-seller/{take}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetBestSellerProducts(int take)
        {
            var products = await _productService.GetBestSellerProducts(take);
            return Ok(products);
        }

        [HttpPost("CreateReview")]
        public async Task<ActionResult> CreateReview([FromBody] ReviewCreateRequest request)
        {
            var reviewId = await _productService.CreateReview(request);
            if (reviewId == 0)
                return BadRequest();
            var product = await _productService.GetByIdReview(reviewId);
            return CreatedAtAction(nameof(GetById), new { id = reviewId }, product);
        }

        [HttpGet("GetAllReviews/{productId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllReviews(int productId)
        {
            var reviews = await _productService.GetAllReviews(productId);
            return Ok(reviews);
        }

        //[HttpPatch("{productId}")]
        //public async void AddViewcount(int productId)
        //{
        //    await _productService.AddViewcount(productId);
        //}

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var affectedResult = await _productService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }

        [HttpPatch("{productId}")]
        public async Task<IActionResult> ChangeActive(int productId)
        {
            var isSuccessful = await _productService.ChangeActive(productId);
            if (isSuccessful)
                return Ok();

            return BadRequest();
        }

        #region Api other

        //[HttpDelete("{productId}")]
        //public async Task<IActionResult> Delete(int productId)
        //{
        //    var affectedResult = await _productService.Delete(productId);
        //    if (affectedResult == 0)
        //        return BadRequest();
        //    return Ok();
        //}

        //[HttpPatch("{productId}/{newPrice}")]
        //public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        //{
        //    var isSuccessful = await _productService.UpdatePrice(productId, newPrice);
        //    if (isSuccessful)
        //        return Ok();

        //    return BadRequest();
        //}

        //[HttpPost("{productId}/images")]
        //[AllowAnonymous]
        //public async Task<IActionResult> CreateImage(int productId, [FromForm] ProductImageCreateRequest request)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var imageId = await _productService.AddImage(productId, request);
        //    if (imageId == 0)
        //        return BadRequest();

        //    var image = await _productService.GetImageById(imageId);

        //    return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        //}

        //[HttpPut("{productId}/images/{imageId}")]
        //[Authorize]
        //public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var result = await _productService.UpdateImage(imageId, request);
        //    if (result == 0)
        //        return BadRequest();

        //    return Ok();
        //}

        //[HttpDelete("{productId}/images/{imageId}")]
        //[Authorize]
        //public async Task<IActionResult> RemoveImage(int imageId)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var result = await _productService.RemoveImage(imageId);
        //    if (result == 0)
        //        return BadRequest();

        //    return Ok();
        //}

        //[HttpGet("{productId}/images/{imageId}")]
        //public async Task<IActionResult> GetImageById(int productId, int imageId)
        //{
        //    var image = await _productService.GetImageById(imageId);
        //    if (image == null)
        //        return BadRequest("Cannot find product");
        //    return Ok(image);
        //}

        #endregion Api other
    }
}