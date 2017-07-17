using System;
using System.Collections.Generic;
using SportsStore.Models;


namespace SportsStore.Models.Repository
{
    public class AdoProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
                {
                    new Product
                    {
                        Name = "Ado Football",
                        Description = "Ado Added",
                        Category = "Ali",
                        Price = 25,
                        ProductID = 1
                    },
                    new Product
                    {
                        Name = "Ado Surf board",
                        Description = "Ado Added",
                        Category = "Ali",
                        Price = 179,
                        ProductID = 2
                    },
                    new Product
                    {
                        Name = "Ado Running shoes",
                        Description = "Ado Added",
                        Category = "Ali",
                        Price = 95,
                        ProductID = 3
                    },
                    new Product{Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports",
                        Price = 275,
                        ProductID = 4
                    },
                     new Product
                     {
                         Name = "Lifejacket",
                         Description = "Protective and fashionable",
                         Category = "Watersports",
                         Price = 48.95m,
                         ProductID = 5
                     },
                new Product
                {
                    Name = "Soccer Ball",
                    Description = "FIFA-approved size and weight",
                    Category = "Soccer",
                    Price = 19.50m,
                    ProductID = 6
                },
                new Product
                {
                    Name = "Corner Flags",
                    Description = "Give your playing field a professional touch",
                    Category = "Soccer",
                    Price = 34.95m,
                    ProductID = 7
                },
                new Product
                {
                    Name = "Stadium",
                    Description = "Flat-packed 35,000-seat stadium",
                    Category = "Soccer",
                    Price = 79500,
                    ProductID = 8
                },
                new Product
                {
                    Name = "Thinking Cap",
                    Description = "Improve brain efficiency by 75%",
                    Category = "Chess",
                    Price = 16,
                    ProductID = 9
                },
                new Product
                {
                    Name = "Unsteady Chair",
                    Description = "Secretly give your opponent a disadvantage",
                    Category = "Chess",
                    Price = 29.95m,
                    ProductID = 10
                },
                new Product
                {
                    Name = "Human Chess Board",
                    Description = "A fun game for the family",
                    Category = "Chess",
                    Price = 75,
                    ProductID = 11
                },
                new Product
                {
                    Name = "Bling-Bling King",
                    Description = "Gold-plated, diamond-studded King",
                    Category = "Chess",
                    Price = 1200,
                    ProductID = 12
                }
            };
        }
    }
}
