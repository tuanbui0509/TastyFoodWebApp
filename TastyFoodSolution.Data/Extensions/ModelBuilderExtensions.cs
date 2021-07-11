using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.Data.Entities;
using TastyFoodSolution.Data.Enums;

namespace TastyFoodSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AppConfig>().HasData(
                  new AppConfig() { Key = "HomeTitle", Value = "This is home page" },
                  new AppConfig() { Key = "HomeSearch", Value = "This is Search page" },
                  new AppConfig() { Key = "HomeDesc", Value = "This is Desc page" }
                  );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                }
                );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Bánh mì",
                    LanguageId = "vi-VN",
                    SeoAlias = "banh-mi",
                    SeoDescription = "Sản phẩm bánh mì Việt Nam",
                    SeoTitle = "Sản phẩm bánh mì Việt Nam"
                },
                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Bread",
                    LanguageId = "en-US",
                    SeoAlias = "bread",
                    SeoDescription = "Bread in Viet Nam",
                    SeoTitle = "Bread in Viet Nam"
                },


                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Đồ ăn nhanh",
                    LanguageId = "vi-VN",
                    SeoAlias = "do-an-nhanh",
                    SeoDescription = "Đồ ăn nhanh Việt Nam",
                    SeoTitle = "Đồ Ăn nhanh Việt Nam"
                },
                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Fast Fodd",
                    LanguageId = "en-US",
                    SeoAlias = "fast-food",
                    SeoDescription = "Fast Fodd in Viet Nam",
                    SeoTitle = "Fast Fodd in Viet Nam"
                });

            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id = 1,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               },
                new Product()
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 150000,
                    Price = 500000,
                    Stock = 0,
                    ViewCount = 0,
                }
               );

            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Bánh mì ăn sáng",
                     LanguageId = "vi-VN",
                     SeoAlias = "banh-mi-an-sang",
                     SeoDescription = "Bánh mì ăn sáng Việt Nam",
                     SeoTitle = "Bánh mì ăn sáng Việt Nam",
                     Details = "Bánh mì ăn sáng Việt Nam",
                     Description = "Bánh mì ăn sáng Việt Nam"
                 },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Bread Breadfast",
                        LanguageId = "en-US",
                        SeoAlias = "bread-breadfast",
                        SeoDescription = "Bread Breadfast Viet Nam",
                        SeoTitle = "Bread Breadfast Viet Nam",
                        Details = "Bread Breadfast Viet Nam",
                        Description = "Bread Breadfast Viet Nam"
                    },

                     new ProductTranslation()
                     {
                         Id = 3,
                         ProductId = 2,
                         Name = "Gà rán",
                         LanguageId = "vi-VN",
                         SeoAlias = "ga-ran",
                         SeoDescription = "Gà rán Việt Nam",
                         SeoTitle = "Gà rán Việt Nam",
                         Details = "Gà rán Việt Nam",
                         Description = "Gà rán Việt Nam"
                     },
                    new ProductTranslation()
                    {
                        Id = 4,
                        ProductId = 2,
                        Name = "Chicken Fried",
                        LanguageId = "en-US",
                        SeoAlias = "chicken-fried",
                        SeoDescription = "Chicken Fried Viet Nam",
                        SeoTitle = "Chicken Fried Viet Nam",
                        Details = "Chicken Fried Viet Nam",
                        Description = "Chicken Fried Viet Nam"
                    });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 },
                new ProductInCategory() { ProductId = 2, CategoryId = 2 }
                );
        }
    }
}
