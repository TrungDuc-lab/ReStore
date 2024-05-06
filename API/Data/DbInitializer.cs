using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Samsung Galaxy S21 Ultra",
                    Description =
                        "Samsung Galaxy S21 Ultra là một trong những chiếc điện thoại cao cấp nhất của Samsung với nhiều tính năng nổi bật như màn hình Dynamic AMOLED, camera siêu zoom 100x và hỗ trợ bút S Pen.",
                    Price = 32990000,
                    PictureUrl = "/images/products/samsung-s21-ultra.png",
                    Brand = "Samsung",
                    Type = "Cao cấp",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Xiaomi Redmi Note 11 Pro",
                    Description =
                        "Xiaomi Redmi Note 11 Pro là một trong những chiếc điện thoại giá rẻ nhưng có cấu hình mạnh mẽ với màn hình AMOLED, camera chất lượng và pin lớn.",
                    Price = 7990000,
                    PictureUrl = "/images/products/xiaomi-redmi-note-11-pro.png",
                    Brand = "Xiaomi",
                    Type = "Tầm trung",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Realme 9 Pro",
                    Description =
                        "Realme 9 Pro là một trong những chiếc điện thoại mới của Realme với thiết kế hiện đại, camera đa chức năng và hiệu suất ổn định.",
                    Price = 6990000,
                    PictureUrl = "/images/products/realme-9-pro.png",
                    Brand = "Realme",
                    Type = "Tầm trung",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Vivo Y72 5G",
                    Description =
                        "Vivo Y72 5G là một trong những chiếc điện thoại 5G của Vivo với thiết kế gọn nhẹ, hiệu suất mạnh mẽ và camera sắc nét.",
                    Price = 5790000,
                    PictureUrl = "/images/products/vivo-y72-5g.png",
                    Brand = "Vivo",
                    Type = "Tầm trung",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Nokia G50",
                    Description =
                        "Nokia G50 là một trong những chiếc điện thoại của Nokia với thiết kế bền bỉ, hiệu suất ổn định và giá cả phải chăng.",
                    Price = 4990000,
                    PictureUrl = "/images/products/nokia-g50.png",
                    Brand = "Nokia",
                    Type = "Giá rẻ",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Huawei Nova 8i",
                    Description =
                        "Huawei Nova 8i là một trong những chiếc điện thoại của Huawei với thiết kế sang trọng, camera đa chức năng và hiệu suất mạnh mẽ.",
                    Price = 7490000,
                    PictureUrl = "/images/products/huawei-nova-8i.png",
                    Brand = "Huawei",
                    Type = "Tầm trung",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Sony Xperia 10 III",
                    Description =
                        "Sony Xperia 10 III là một trong những chiếc điện thoại của Sony với thiết kế đẹp mắt, màn hình OLED và camera chất lượng.",
                    Price = 9990000,
                    PictureUrl = "/images/products/sony-xperia-10-iii.png",
                    Brand = "Sony",
                    Type = "Cao cấp",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Motorola Moto G60",
                    Description =
                        "Motorola Moto G60 là một trong những chiếc điện thoại giá rẻ của Motorola với màn hình lớn, camera đa chức năng và pin lớn.",
                    Price = 6990000,
                    PictureUrl = "/images/products/motorola-moto-g60.png",
                    Brand = "Motorola",
                    Type = "Tầm trung",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "iPhone 13 Pro Max",
                    Description =
                        "iPhone 13 Pro Max là một trong những chiếc điện thoại cao cấp nhất của Apple với thiết kế sang trọng, camera chất lượng và hiệu suất mạnh mẽ.",
                    Price = 33990000,
                    PictureUrl = "/images/products/iphone-13-pro-max.png",
                    Brand = "Apple",
                    Type = "Cao cấp",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "OnePlus 10 Pro",
                    Description =
                        "OnePlus 10 Pro là một trong những chiếc điện thoại cao cấp của OnePlus với thiết kế đẹp mắt, màn hình AMOLED và hiệu suất ổn định.",
                    Price = 28990000,
                    PictureUrl = "/images/products/oneplus-10-pro.png",
                    Brand = "OnePlus",
                    Type = "Cao cấp",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Xiaomi Redmi 10A",
                    Description =
                        "Xiaomi Redmi 10A là một trong những chiếc điện thoại giá rẻ của Xiaomi với thiết kế đơn giản, pin lớn và camera đa chức năng.",
                    Price = 2290000,
                    PictureUrl = "/images/products/xiaomi-redmi-10a.png",
                    Brand = "Xiaomi",
                    Type = "Giá rẻ",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Realme C25",
                    Description =
                        "Realme C25 là một trong những chiếc điện thoại giá rẻ của Realme với thiết kế bền bỉ, pin trâu và hiệu suất ổn định.",
                    Price = 2990000,
                    PictureUrl = "/images/products/realme-c25.png",
                    Brand = "Realme",
                    Type = "Giá rẻ",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Samsung Galaxy M32",
                    Description =
                        "Samsung Galaxy M32 là một trong những chiếc điện thoại tầm trung của Samsung với thiết kế hiện đại, màn hình AMOLED và camera đa chức năng.",
                    Price = 5990000,
                    PictureUrl = "/images/products/samsung-galaxy-m32.png",
                    Brand = "Samsung",
                    Type = "Tầm trung",
                    QuantityInStock = 100
                }
            };

            // context.Products.AddRange(products);

            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
    }
}