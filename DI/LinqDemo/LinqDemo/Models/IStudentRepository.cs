using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqDemo.Models
{
    public interface IStudentRepository
    {
        Student GetStuById(int StudentId);
        List<Student> GetAllStudents();
    }
}
