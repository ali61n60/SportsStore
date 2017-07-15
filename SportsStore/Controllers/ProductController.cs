﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.IOC;
using SportsStore.Models;
using SportsStore.Models.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        //Bootstrapper.container.GetInstance<ICategoryRepository>()
        public ProductController()
        {
            repository = Bootstrapper.container.GetInstance<IProductRepository>();
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult List() => View(repository.GetProducts());
    }
}
