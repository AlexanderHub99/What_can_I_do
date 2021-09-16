using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using What_can_I_do_.DomainMyToDoList;
using What_can_I_do_.Models;


namespace What_can_I_do_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly ArticlesRepository articlesRepository;
        public HomeController(ILogger<HomeController> logger) /*ArticlesRepository articlesRepository*/ 
        {
            _logger = logger;
           // this.articlesRepository = articlesRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult SimpleTasks(string pIN  )
        {
            ViewBag.pIN = pIN;
            ViewBag.Message = CheckPIN.ValidatePin(pIN);

            return View();
        }
       
        public IActionResult MyToDoList()
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
