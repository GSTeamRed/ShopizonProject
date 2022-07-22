using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShopizonProject.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Cars"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Electronics"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Furniture"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Shoes"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Soda"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Convertible ",
                    Description = "This Car doesnt have a top! Enjoy the Breeze!",
                    ImagePath="catalog/convertible.jpg",
                    UnitPrice = 30000,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Model T",
                    Description = "This was the first car made.",
                    ImagePath="catalog/model-t.jpg",
                    UnitPrice = 10000,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Ferrari",
                    Description = "This is a luxury sports car",
                    ImagePath="catalog/ferrari.jpg",
                    UnitPrice = 125000,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Bugatti",
                    Description = "Once the worlds fastest car",
                    ImagePath="bugatti.jpg",
                    UnitPrice = 175000,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Formula 1",
                    Description = "You need a special license to drive this car",
                    ImagePath="formula1.jpg",
                    UnitPrice = 300000,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Laptop",
                    Description = "Portable Computer.",
                    ImagePath="laptop.jpg",
                    UnitPrice = 150,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Iphone",
                    Description = "Apple's cellular phone",
                    ImagePath="iphone.jpg",
                    UnitPrice = 100,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Galaxy S10",
                    Description = "Samsungs cellular phone.",
                    ImagePath="galaxy.jpg",
                    UnitPrice = 100,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "iPad",
                    Description = "Apple's tablet",
                    ImagePath="ipad.jpg",
                    UnitPrice = 150,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Couch",
                    Description = "This can sit you and all your friends",
                    ImagePath="couch.jpg",
                    UnitPrice = 200.00,
                    CategoryID = 3
                },
               
                new Product
                {
                    ProductID = 11,
                    ProductName = "Table",
                    Description = "Dining room table that seats up to 6 people",
                    ImagePath="table.jpg",
                    UnitPrice = 100.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Chair",
                    Description = "If you buy 6 of these you can have a full dining room set",
                    ImagePath="chair.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Nike",
                    Description = "All shoes Nike.",
                    ImagePath="nike.jpg",
                    UnitPrice = 100.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Adidas",
                    Description = "All shoes Adidas.",
                    ImagePath="adidas.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "New Balance",
                    Description = "All shoes New Balance.",
                    ImagePath="newbalance.jpg",
                    UnitPrice = 75.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Dr.Pepper",
                    Description = "The best pop that you will ever drink.",
                    ImagePath="drpepper.jpg",
                    UnitPrice = 1.25,
                    CategoryID = 5
                },
                 new Product
                {
                    ProductID = 17,
                    ProductName = "Ottoman",
                    Description = "This will go well with the couch.",
                    ImagePath="ottoman.jpg",
                    UnitPrice = 20.00,
                    CategoryID = 3
                }
            };

            return products;
        }
    }
}