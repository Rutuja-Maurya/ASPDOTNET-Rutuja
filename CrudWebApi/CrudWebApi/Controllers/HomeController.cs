using CrudWebApi.Infra;
using CrudWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    [Route("Home")]
    public class HomeController : Controller
    {
       /* private readonly ILogger<HomeController> _logger;*/
        private readonly IEmployeetable _repo;

        public HomeController(IEmployeetable repo)
        {
            _repo = repo;
        }
        
        [HttpGet]
        [Route("Index")]

        public IActionResult Index()
        {
            var emplist = _repo.GetEmplyeetables();
            return Ok(emplist);
            
        }

        [HttpGet]
        public IActionResult Create()
        {

            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Employeetable employeetable)
        {
            _repo.Create(employeetable);
            return Ok();

        }
        /*[HttpGet]
        public IActionResult Edit(int Id)
        {
            var empedit = _repo.GetEmployeetable(Id);
            return Ok(empedit);
        }
        [HttpPost]
        public IActionResult Edit(Employeetable employeetable)
        {
            _repo.Update(employeetable);
            return Ok();
        }*/
    }
}
