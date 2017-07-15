using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
