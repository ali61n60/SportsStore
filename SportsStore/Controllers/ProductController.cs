using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;
        public int PageSize = 6;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        public ViewResult List(int page = 1)
        {
          return  View(_repository.GetProducts()
                .OrderBy(p => p.ProductID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize));
        }
    }
}
