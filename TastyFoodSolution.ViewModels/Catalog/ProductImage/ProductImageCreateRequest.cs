using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyFoodSolution.ViewModels.Catalog.ProductImage
{
    public class ProductImageCreateRequest
    {
        public bool IsDefault { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}