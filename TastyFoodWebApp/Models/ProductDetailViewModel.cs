﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Catalog.Categories;
using TastyFoodSolution.ViewModels.Catalog.ProductImage;
using TastyFoodSolution.ViewModels.Catolog.Products;

namespace TastyFoodWebApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryViewModel Category { get; set; }

        public ProductViewModel Product { get; set; }

        public List<ProductViewModel> RelatedProducts { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}