using Microsoft.AspNetCore.Mvc;
using SportsStore.Models.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;
        
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult List() => View(_repository.GetProducts());
    }
}
