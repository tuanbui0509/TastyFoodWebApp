using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TastyFoodSolution.Data.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public int QuantityOrder { set; get; }
        public DateTime DateCreated { set; get; }
        public bool? IsFeatured { get; set; }
        public bool? IsActive { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public int CategoryId { set; get; }
        public Category Category { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public List<Cart> Carts { get; set; }
        public List<Review> Reviews { get; set; }

        public List<ProductImage> ProductImages { get; set; }
    }
}