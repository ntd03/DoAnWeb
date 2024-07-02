using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Data
{
    public class ShopOnlineDbContext : DbContext
    {
        public ShopOnlineDbContext(DbContextOptions<ShopOnlineDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Products
            //Beauty Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Bộ Làm Đẹp Glossier",
                Description = "Bộ sản phẩm của Glossier, bao gồm sản phẩm chăm sóc da, chăm sóc tóc và trang điểm",
                ImageURL = "/Images/Beauty/Beauty1.png",
                Price = 100,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Bộ Chăm Sóc Da Curology",
                Description = "Bộ sản phẩm của Curology, bao gồm sản phẩm chăm sóc da",
                ImageURL = "/Images/Beauty/Beauty2.png",
                Price = 50,
                Qty = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Dầu Dừa Hữu Cơ Cocooil",
                Description = "Sản phẩm dầu dừa hữu cơ của Cocooil",
                ImageURL = "/Images/Beauty/Beauty3.png",
                Price = 20,
                Qty = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Bộ Chăm Sóc Tóc Và Da Schwarzkopf",
                Description = "Bộ sản phẩm của Schwarzkopf, bao gồm chăm sóc da và tóc",
                ImageURL = "/Images/Beauty/Beauty4.png",
                Price = 50,
                Qty = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Bộ Chăm Sóc Da",
                Description = "Bộ sản phẩm chăm sóc da, bao gồm sản phẩm chăm sóc da và tóc",
                ImageURL = "/Images/Beauty/Beauty5.png",
                Price = 30,
                Qty = 85,
                CategoryId = 1

            });
            //Electronics Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Tai Nghe Air Pods",
                Description = "Tai nghe Air Pods - tai nghe không dây",
                ImageURL = "/Images/Electronic/Electronics1.png",
                Price = 100,
                Qty = 120,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Tai Nghe Vàng",
                Description = "Tai nghe vàng - tai nghe không không dây",
                ImageURL = "/Images/Electronic/Electronics2.png",
                Price = 40,
                Qty = 200,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Tai Nghe Đen",
                Description = "Tai nghe đen - tai nghe không không dây",
                ImageURL = "/Images/Electronic/Electronics3.png",
                Price = 40,
                Qty = 300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Máy Ảnh Kỹ Thuật Số Sennheiser",
                Description = "Máy ảnh kỹ thuật số chất lượng cao của Sennheiser - kèm chân máy",
                ImageURL = "/Images/Electronic/Electronic4.png",
                Price = 600,
                Qty = 20,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Máy Ảnh Kỹ Thuật Số Canon",
                Description = "Máy ảnh kỹ thuật số chất lượng cao của Canon",
                ImageURL = "/Images/Electronic/Electronic5.png",
                Price = 500,
                Qty = 15,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Máy Chơi Game Nintendo",
                Description = "Máy chơi game của Nintendo",
                ImageURL = "/Images/Electronic/technology6.png",
                Price = 100,
                Qty = 60,
                CategoryId = 3
            });
            //Furniture Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Ghế Văn Phòng Da Đen",
                Description = "Ghế văn phòng da đen rất thoải mái",
                ImageURL = "/Images/Furniture/Furniture1.png",
                Price = 50,
                Qty = 212,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Ghế Văn Phòng Da Hồng",
                Description = "Ghế văn phòng da hồng rất thoải mái",
                ImageURL = "/Images/Furniture/Furniture2.png",
                Price = 50,
                Qty = 112,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Ghế Thư Giãn",
                Description = "Ghế thư giãn rất thoải mái",
                ImageURL = "/Images/Furniture/Furniture3.png",
                Price = 70,
                Qty = 90,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Ghế Thư Giãn Bạc",
                Description = "Ghế thư giãn bạc rất thoải mái",
                ImageURL = "/Images/Furniture/Furniture4.png",
                Price = 120,
                Qty = 95,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Đèn Bàn Sứ",
                Description = "Đèn bàn sứ màu trắng và xanh",
                ImageURL = "/Images/Furniture/Furniture6.png",
                Price = 15,
                Qty = 100,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Đèn Bàn Văn Phòng",
                Description = "Đèn bàn văn phòng",
                ImageURL = "/Images/Furniture/Furniture7.png",
                Price = 20,
                Qty = 73,
                CategoryId = 2
            });
            //Shoes Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Giày Puma",
                Description = "Giày Puma thoải mái với nhiều kích cỡ",
                ImageURL = "/Images/Shoes/Shoes1.png",
                Price = 100,
                Qty = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Giày Màu Sắc",
                Description = "Giày màu sắc - có sẵn nhiều kích cỡ",
                ImageURL = "/Images/Shoes/Shoes2.png",
                Price = 150,
                Qty = 60,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Giày Nike Xanh",
                Description = "Giày Nike xanh - có sẵn nhiều kích cỡ",
                ImageURL = "/Images/Shoes/Shoes3.png",
                Price = 200,
                Qty = 70,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "Giày Hummel Màu Sắc",
                Description = "Giày Hummel màu sắc - có sẵn nhiều kích cỡ",
                ImageURL = "/Images/Shoes/Shoes4.png",
                Price = 120,
                Qty = 120,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "Giày Nike Đỏ",
                Description = "Giày Nike đỏ - có sẵn nhiều kích cỡ",
                ImageURL = "/Images/Shoes/Shoes5.png",
                Price = 200,
                Qty = 100,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Dép Birkenstock",
                Description = "Dép Birkenstock - có sẵn nhiều kích cỡ",
                ImageURL = "/Images/Shoes/Shoes6.png",
                Price = 50,
                Qty = 150,
                CategoryId = 4
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Bob"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Sarah"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Làm Đẹp",
                IconCSS = "fas fa-spa"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Nội Thất",
                IconCSS = "fas fa-couch"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Điện Tử",
                IconCSS = "fas fa-headphones"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Giày Dép",
                IconCSS = "fas fa-shoe-prints"
            });


        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public object Orders { get; internal set; }
    }
}
