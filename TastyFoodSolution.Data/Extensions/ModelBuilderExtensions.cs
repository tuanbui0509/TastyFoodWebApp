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
                   Description = "Bánh mì ăn sáng Việt Nam",
                   CategoryId = 1
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
                    Description = "Gà rán Việt Nam",
                    CategoryId = 2
                }
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

            // any guid
            var roleIdUser = new Guid("CE7E4C06-84B0-4114-912F-7E27F245DC47");
            var userId = new Guid("AA16F18B-95B9-4E6A-837E-EFB5B8E63E84");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleIdUser,
                Name = "User",
                NormalizedName = "user",
                Description = "User role"
            });

            var hasherUser = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = userId,
                UserName = "user",
                NormalizedUserName = "user",
                Email = "user@gmail.com",
                NormalizedEmail = "user@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasherUser.HashPassword(null, "User@123"),
                SecurityStamp = string.Empty,
                FirstName = "User",
                LastName = "My",
                Dob = new DateTime(2021, 07, 15)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleIdUser,
                UserId = userId
            });
        }
    }
}