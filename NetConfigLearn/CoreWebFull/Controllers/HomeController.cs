using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreWebFull.Models;
using Ioc测试.BaseClass;

namespace CoreWebFull.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Dao _dao;

        public HomeController(ILogger<HomeController> logger, Dao dao)
        {
            _logger = logger;
            _dao = dao;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("------------------这个是我刚刚注入的方法---------------------");
            _dao.insert();
            _logger.LogInformation("------------------这个是我刚刚注入的方法---------------------");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
