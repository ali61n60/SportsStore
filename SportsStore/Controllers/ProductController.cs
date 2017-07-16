using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models.Repository;
using SportsStore.Models.ViewModels;

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

        public ViewResult List(string category,int page = 1)
        {
            return View(new ProductsListViewModel
            {
                Products = _repository.GetProducts()
                    .Where(p=>category==null || p.Category==category)
                    .OrderBy(p => p.ProductID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                     TotalItems = category == null ?
                        _repository.GetProducts().Count() :
                        _repository.GetProducts().Count(e => e.Category == category)
                },
                CurrentCategory = category
            });
        }
    }
}
