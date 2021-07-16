using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyFoodSolution.ViewModels.Catolog.Products
{
    public class ProductCreateRequest
    {
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }

        public bool? IsFeatured { get; set; }

        public IFormFile ThumbnailImage { get; set; }
    }
}