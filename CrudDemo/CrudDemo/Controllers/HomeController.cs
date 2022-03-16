using CrudDemo.Infra;
using CrudDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CrudDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentstab _repo;


        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(IStudentstab repo)
        {
            _repo = repo; 
        }
        [HttpGet]
        public IActionResult Index()
        {
            var studlist = _repo.GetStudentstabs();
            return View(studlist);
        }

        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(Studentstab studentstab)
        {
            _repo.Create(studentstab);
            return View();

        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var studedit = _repo.GetStudentstab(Id);
            return View(studedit);
        }
        [HttpPost]
        public IActionResult Edit(Studentstab studentstab)
        {
            _repo.Update(studentstab);
            return View();
        }
        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
