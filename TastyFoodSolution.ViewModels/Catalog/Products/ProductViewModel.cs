using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.Data.Entities;

namespace TastyFoodSolution.ViewModels.Catolog.Products
{
    public class ProductViewModel
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public string Description { set; get; }
        public bool? IsFeatured { get; set; }
        public List<ProductImage> ListImage { get; set; }
        public string ThumbnailImage { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { set; get; }
        public int QuantityOrder { set; get; }
    }
}