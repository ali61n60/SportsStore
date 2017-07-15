using System;
using System.Collections.Generic;
using SportsStore.Models;

namespace Repository
{
    public class AdoProductRepository:IProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
                {
                    new Product {Name = "Ado Football", Price = 25},
                    new Product {Name = "Ado Surf board", Price = 179},
                    new Product {Name = "Ado Running shoes", Price = 95}
                };
        }
    }
}
