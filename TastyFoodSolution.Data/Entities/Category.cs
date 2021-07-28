using TastyFoodSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace TastyFoodSolution.Data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public Status Status { set; get; }
        public string Name { set; get; }
        public string Desciption { set; get; }
        public string Thumb { set; get; }
        public List<Product> Products { get; set; }
    }
}