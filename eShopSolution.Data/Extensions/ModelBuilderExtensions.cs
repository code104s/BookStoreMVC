using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extentions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false }
                );
            #region Seed Category
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Tình cảm"
                },

                new Category()
                {
                    Id = 2,
                    Name = "Truyện ngắn"
                },

                new Category()
                {
                    Id = 3,
                    Name = "Giả tưởng"
                },

                new Category()
                {
                    Id = 4,
                    Name = "Kinh dị"
                },

                new Category()
                {
                    Id = 5,
                    Name = "Truyền cảm hứng"
                },

                new Category()
                {
                    Id = 6,
                    Name = "Bài luận"
                }
              );
            #endregion

            #region Seed Product
            modelBuilder.Entity<Product>().HasData(
                 new Product()
                 {
                     Id = 1,
                     Name = "Cuốn theo chiều gió",
                     CategoryId = 1,
                     Price = 200000,
                     Stock = 5,
                     DateCreated = DateTime.Now,
                     Description = "",
                     Details = ""
                 },

                new Product()
                {
                    Id = 2,
                    Name = "Ngọn đèn không tắt",
                    CategoryId = 2,
                    Price = 290000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                },

                new Product()
                {
                    Id = 3,
                    Name = "80 NGÀY VÒNG QUANH THẾ GIỚI",
                    CategoryId = 3,
                    Price = 80000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                },

                new Product()
                {
                    Id = 4,
                    Name = "Sĩ Số Lớp Vắng 0",
                    CategoryId = 4,
                    Price = 99000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                },

                new Product()
                {
                    Id = 5,
                    Name = "Tuổi trẻ đáng giá bao nhiêu?",
                    CategoryId = 5,
                    Price = 50000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                },

                new Product()
                {
                    Id = 6,
                    Name = "50 bài luận tiếng Anh",
                    CategoryId = 6,
                    Price = 30000,
                    Stock = 5,
                    DateCreated = DateTime.Now,
                    Description = "",
                    Details = ""
                }
             );
            #endregion

            // tạo data cho user mặc định
            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");

            modelBuilder.Entity<AppRole>().HasData(
            new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            }
            );
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "nguyenthanhtoanx2@gmail.com",
                PhoneNumber = "033124183",
                Address = "ABCDXYZ",
                NormalizedEmail = "NGUYENTHANHTOAN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                Name = "Nguyen Toan Dev",
            }); 
            // gán role admin và admin user
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
