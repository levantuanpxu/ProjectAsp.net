using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Demo1.Models;
using Microsoft.EntityFrameworkCore;
using Demo1.ViewsModels;

namespace Demo1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _appDbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM()
            {
                Products = _appDbContext.Products.Include(p => p.Category).ToList(),
                Categories = _appDbContext.Categories
            };


            return View(homeIndexVM);
        }

        public IActionResult Index1()
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM()
            {
                Products = _appDbContext.Products.Include(p => p.Category).ToList(),
                Categories = _appDbContext.Categories
            };


            return View(homeIndexVM);
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult whatdo()
        {
            return View();
        }
        public IActionResult projects()
        {
            return View();
        }
        public IActionResult blog()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }

        public IActionResult Demo()
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM()
            {
                /*Products = _appDbContext.Products.Where(prod => EF.Functions.Like(prod.Name, "%a%")).Include(p => p.Category).ToList(),*/
                Products = _appDbContext.Products.Include(p => p.Category).ToList(),
                Categories = _appDbContext.Categories
            };


            return View(homeIndexVM);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
