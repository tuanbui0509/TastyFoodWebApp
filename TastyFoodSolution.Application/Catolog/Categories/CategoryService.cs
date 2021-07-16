using TastyFoodSolution.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TastyFoodSolution.Data.EF;

namespace TastyFoodSolution.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly TastyFoodDBContext _context;

        public CategoryService(TastyFoodDBContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryVm>> GetAll(string languageId)
        {
            var query = from c in _context.Categories
                        select new { c };
            return await query.Select(x => new CategoryVm()
            {
                Id = x.c.Id,
                Name = x.c.Name
            }).ToListAsync();
        }
    }
}