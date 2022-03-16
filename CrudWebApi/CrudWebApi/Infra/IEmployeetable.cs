using CrudWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWebApi.Infra
{
    public interface IEmployeetable
    {
        public List<Employeetable> GetEmplyeetables();
        public Employeetable GetEmployeetable(int Id);
        public void Create(Employeetable employeetable);
        // public void DeleteStudent(Studentstab studentstab);
        /*public void Update(Employeetable employeetable);*/
     
    }
}
