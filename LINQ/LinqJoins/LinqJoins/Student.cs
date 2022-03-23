using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoins
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Standard { get; set; }

        public static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student {RollNo = 101, Name = "Rutuja", Standard = 10},
                new Student {RollNo = 102, Name = "Shruti", Standard = 8},
                new Student {RollNo = 103, Name = "Aishwariya", Standard = 10},
                new Student {RollNo = 104, Name = "Shreyas", Standard = 8},
                new Student {RollNo = 105, Name = "Piyush", Standard = 6},
                new Student {RollNo = 106, Name = "Rishi", Standard = 6},
                new Student {RollNo = 107, Name = "Minal", Standard = 2},
                new Student {RollNo = 108, Name = "Ravi", Standard = 6},
            };
        }


    }
}
