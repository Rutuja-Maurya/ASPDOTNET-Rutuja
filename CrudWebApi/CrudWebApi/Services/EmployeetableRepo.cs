using CrudWebApi.Data;
using CrudWebApi.Infra;
using CrudWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWebApi.Services
{
    public class EmployeetableRepo : IEmployeetable
    {
        public DatabaseContext _context;
        public EmployeetableRepo(DatabaseContext context)
        {
            _context = context;
        }
        public List<Employeetable> GetEmployeetables()
        {
            return _context.Employeetable.ToList();

        }
        public Employeetable GetEmployeetable(int Id)
        {
            return _context.Employeetable.FirstOrDefault(st => st.Id == st.Id);
        }
        public void Create(Employeetable employeetable)
        {
            _context.Add(employeetable);
            _context.SaveChanges();
        }

        public List<Employeetable> GetEmplyeetables()
        {
            throw new NotImplementedException();
        }
        /* public void Update(Employeetable employeetable)
 {
     _context.Update(employeetable);
     _context.SaveChanges();
 }
*/

    }
}
