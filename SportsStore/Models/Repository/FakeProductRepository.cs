using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models.Repository
{
    public class FakeProductRepository:IProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product {Name = "Fake Football", Price = 25},
                new Product {Name = "Fake Surf board", Price = 179},
                new Product {Name = "Fake Running shoes", Price = 95}
            };
        }
    }
}
