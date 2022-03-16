using LinqDemo.Models;
using LinqDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqDemo.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class StudentController : Controller
    {
        private readonly StudentService _StudentService = null;

        public StudentController(StudentService studentService)
        {
            _StudentService = studentService;
        }

     [HttpGet]
    public ActionResult GetAllStudents()
        {
           try
            {
                List<Student> studetails = _StudentService.GetAllStudents();
                return Ok(studetails);
            }
            catch (Exception)
            {
                throw;
            }
           
            

        }
        [HttpGet]
        
        public ActionResult GetStuById(int StudentId)
        {
           // DemoTestRepository repository = new DemoTestRepository();
            Student studetails = _StudentService.GetStuById(StudentId);
            return Ok(studetails);

        }
    }
}
