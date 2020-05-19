using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Web.Models;

namespace Portfolio.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly PortfolioContext _context;

        public HomeController(PortfolioContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var articles = _context.Articles.OrderByDescending(a => a.Date).Take(3);
            return View(articles);
        }

        public async Task<IActionResult> About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}