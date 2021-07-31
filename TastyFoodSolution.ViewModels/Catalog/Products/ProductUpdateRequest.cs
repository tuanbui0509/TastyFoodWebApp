using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyFoodSolution.ViewModels.Catolog.Products
{
    public class ProductUpdateRequest
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public bool? IsFeatured { get; set; }
        public bool? IsActive { get; set; }
        public int CategoryId { get; set; }

        public IFormFile ThumbnailImage { get; set; }
    }
}