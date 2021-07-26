using TastyFoodSolution.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TastyFoodSolution.Data.EF;
using TastyFoodSolution.ViewModels.Catolog.Products;

namespace TastyFoodSolution.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly TastyFoodDBContext _context;

        public CategoryService(TastyFoodDBContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            var query = from c in _context.Categories
                        select new { c };
            return await query.Select(x => new CategoryViewModel()
            {
                Id = x.c.Id,
                Name = x.c.Name,
                Thumb = x.c.Thumb,
                Desciption = x.c.Desciption
            }).ToListAsync();
        }

        public async Task<List<ProductViewModel>> GetAllProductById(int categoryId)
        {
            //1. Select join
            var query = from p in _context.Products
                        join pi in _context.ProductImages on p.Id equals pi.ProductId into ppi
                        from pi in ppi.DefaultIfEmpty()
                        join c in _context.Categories on p.CategoryId equals c.Id into pc
                        from c in pc.DefaultIfEmpty()
                        where c.Id == categoryId && (pi.IsDefault == true)
                        select new { p, c, pi };

            var data = await query.Select(x => new ProductViewModel()
            {
                Id = x.p.Id,
                Name = x.p.Name,
                DateCreated = x.p.DateCreated,
                Description = x.p.Description,
                OriginalPrice = x.p.OriginalPrice,
                Price = x.p.Price,
                Stock = x.p.Stock,
                ViewCount = x.p.ViewCount,
                ThumbnailImage = x.pi.ImagePath,
                CategoryName = x.c.Name,
                QuantityOrder = x.p.QuantityOrder,
                CategoryId = x.p.CategoryId,
            }).ToListAsync();

            return data;
        }

        public async Task<CategoryViewModel> GetById(int id)
        {
            var query = from c in _context.Categories
                        where c.Id == id
                        select new { c };
            return await query.Select(x => new CategoryViewModel()
            {
                Id = x.c.Id,
                Name = x.c.Name,
                Thumb = x.c.Thumb
            }).FirstOrDefaultAsync();
        }
    }
}