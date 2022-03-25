using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudLinqAPi.Model
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
