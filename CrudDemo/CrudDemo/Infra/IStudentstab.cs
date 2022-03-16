using CrudDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudDemo.Infra
{
    public interface IStudentstab
    {
        public List<Studentstab> GetStudentstabs();
        public Studentstab GetStudentstab(int Id);
        public void Create(Studentstab studentstab);
       // public void DeleteStudent(Studentstab studentstab);
        public void Update(Studentstab studentstab);

    }
}
