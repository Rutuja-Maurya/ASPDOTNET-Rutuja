using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudDemo.Models
{
    public class Studentstab
    {
      [Key]
        public int Id { get; set; }
       public string Name { get; set; }
       public string Course { get; set; }
    }
}
