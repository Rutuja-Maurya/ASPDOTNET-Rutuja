using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoins
{
    class Standard
    {
        public int Id { get; set; }
        public string ClassTeacher { get; set; }
        public int Fees { get; set; }

        public static new List<Standard> GetClasses()
        {
            return new List<Standard>
            {
                new Standard { Id = 10, ClassTeacher = "Max", Fees = 1000 },
                new Standard { Id = 8, ClassTeacher = "Ajay", Fees = 800 },
                new Standard { Id = 6, ClassTeacher = "Geeta", Fees = 600 },
                new Standard { Id = 4, ClassTeacher = "Rohan", Fees = 400 },
            };

        }
    }
}



