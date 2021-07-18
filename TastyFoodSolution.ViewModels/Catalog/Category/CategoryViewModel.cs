using System;
using System.Collections.Generic;
using System.Text;

namespace TastyFoodSolution.ViewModels.Catalog.Categories
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Thumb { get; set; }

        public int? ParentId { get; set; }
    }
}