using CrudLinqAPi.Model;
using CrudLinqAPi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudLinqAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        TeacherServices _repo;
        public HomeController(TeacherServices repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("GetTeachers")]
        public IActionResult GetTeachers()
        {
            var tea = _repo.GetTeachers();
            return Ok(tea);
        }
        [HttpGet]
        [Route("GetTeacherbyname")]
        public IActionResult GetTeacherbyname()
        {

            var tea = _repo.GetTeacherbyname();
            return Ok(tea);
        }
        [HttpGet]
        [Route("AddTeacher")]
        public IActionResult AddTeacher()
        {
            return Ok();
        }

        [HttpPost]
        [Route("AddTeacher")]
        public IActionResult AddTeacher(Teacher tea)
        {
            _repo.AddTeacher(tea);
            return Ok();

        }

        [HttpGet]
        [Route("UpdateTeacher")]
        public IActionResult UpdateTeacher()
        {
            return Ok();
        }

        [HttpPut]
        [Route("UpdateTeacher")]

        public IActionResult UpdateTeacher(Teacher tea)
        {
            _repo.UpdateTeacher(tea);
            return Ok();
        }

        [HttpGet]
        [Route("DeleteTeacher")]
        public IActionResult DeleteTeacher(int Id)
        {
            var car = _repo.GetTeacher(Id);
            return Ok(car);
        }

        [HttpDelete]
        [Route("DeleteTeacher")]
        public IActionResult DeleteEmp(Teacher tea)
        {
            _repo.DeleteTeacher(tea);
            return Ok();
        }

    }
}
