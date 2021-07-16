using Microsoft.AspNetCore.Identity;
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

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Name = "Bánh mì",
                    Status = Status.Active,
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Name = "Đồ ăn nhanh",
                    Status = Status.Active,
                }
                );

            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id = 1,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   Name = "Bánh mì ăn sáng",
                   Details = "Bánh mì ăn sáng Việt Nam",
                   Description = "Bánh mì ăn sáng Việt Nam"
               },
                new Product()
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 150000,
                    Price = 500000,
                    Stock = 0,
                    ViewCount = 0,
                    Name = "Gà rán",
                    Details = "Gà rán Việt Nam",
                    Description = "Gà rán Việt Nam"
                }
               );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 },
                new ProductInCategory() { ProductId = 2, CategoryId = 2 }
                );

            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "tuanbui0509@gmail.com",
                NormalizedEmail = "tuanbui0509@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "tuanbui0509"),
                SecurityStamp = string.Empty,
                FirstName = "Tuan",
                LastName = "Ngoc",
                Dob = new DateTime(2021, 07, 11)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}