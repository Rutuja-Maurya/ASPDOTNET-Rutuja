using System;
using System.Linq;

namespace LinqJoins
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = Student.GetStudents();
            var classes = Standard.GetClasses();

            var data = from s in students
                       join c in classes
                       on s.Standard equals c.Id
                       select new
                       {
                           StudentName = s.Name,
                           Teacher = c.ClassTeacher
                       };
            //join using extension method
            //var data = students.Join(classes, s => s.Standard, c => c.Id, (st, cl) => new
            //{
            //    StudentName = st.Name,
            //    Teacher = cl.ClassTeacher
            //});

            //foreach (var item in data)
            //{
            //    Console.WriteLine($"{item.StudentName} - {item.Teacher}");
            //}
            //Console.WriteLine("Hello World!");
        }
    }
}
