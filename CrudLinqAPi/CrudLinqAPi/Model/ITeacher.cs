using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudLinqAPi.Model
{
    public interface ITeacher
    {
        public List<Teacher> GetTeachers();
        public Teacher GetTeacher(int TeacherId);
        public void AddTeacher(Teacher Teacher);
        public void UpdateTeacher(Teacher Teacher);
        public void DeleteTeacher(Teacher Teacher);
        public List<Teacher> GetTeacherbyname();
        public List<Teacher> GetTeachersal();
      
    }
}
