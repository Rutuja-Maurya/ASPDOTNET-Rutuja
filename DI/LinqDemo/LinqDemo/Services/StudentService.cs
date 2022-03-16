using LinqDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqDemo.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _repo = null;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }
        public List<Student> GetAllStudents()
        {
            return _repo.GetAllStudents();

        }
        public Student GetStuById(int StudentId)
        {
            return _repo.GetStuById(StudentId);
        }
    }
}
