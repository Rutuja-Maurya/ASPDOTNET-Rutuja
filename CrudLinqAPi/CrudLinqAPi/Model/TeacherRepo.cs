using CrudLinqAPi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudLinqAPi.Model
{
    public class TeacherRepo:ITeacher
    {
        databaseContext _context;
        public TeacherRepo(databaseContext context)
        {
            _context = context;
        }
        public List<Teacher> GetTeachers()
        {
            return _context.Teacher.ToList();

        }
        public Teacher GetTeacher(int Id)
        {
            return _context.Teacher.FirstOrDefault(e => e.Id == Id);

        }
        public void AddTeacher(Teacher Teacher)

        {
            _context.Add(Teacher);
            _context.SaveChanges();
        }
        public void UpdateTeacher(Teacher Teacher)
        {
            _context.Update(Teacher);
            _context.SaveChanges();

        }
        public void DeleteTeacher(Teacher Teacher)
        {
            _context.Remove(Teacher);
            _context.SaveChanges();

        }
        public List<Teacher> GetTeacherbyname()
        {
            return _context.Teacher.ToList();
        }
        public List<Teacher> GetTeachersal()
        {
            return _context.Teacher.ToList();
        }
       
    }
    }

