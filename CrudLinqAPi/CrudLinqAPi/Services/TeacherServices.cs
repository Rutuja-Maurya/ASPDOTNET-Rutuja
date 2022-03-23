using CrudLinqAPi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudLinqAPi.Services
{
    public class TeacherServices
    {
        ITeacher _service;
        public TeacherServices(ITeacher service)
        {
            _service = service;
        }
        public List<Teacher> GetTeachers()
        {
            List<Teacher> Teacher = _service.GetTeachers();
            return Teacher.OrderBy(t => t.Name).ToList();
      
            
        }
        public Teacher GetTeacher(int ID)
        {
            return _service.GetTeacher(ID);

        }
        public void AddTeacher(Teacher Teacher)
        {
            _service.AddTeacher(Teacher);
        }
        public void UpdateTeacher(Teacher Teacher)
        {
            _service.UpdateTeacher(Teacher);
        }
        public void DeleteTeacher(Teacher Teacher)
        {
           
            _service.DeleteTeacher(Teacher);
        }
        public List<Teacher> GetTeacherbyname()
        {
            List<Teacher> Teacher = _service.GetTeacherbyname();
            return Teacher.Where(s => s.Salary >= 10000).ToList();
            
         
          
            

        }

    }
}
