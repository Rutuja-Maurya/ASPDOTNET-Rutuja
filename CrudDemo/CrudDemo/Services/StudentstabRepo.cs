using CrudDemo.Data;
using CrudDemo.Infra;
using CrudDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace CrudDemo.Services
{
    public class StudentstabRepo : IStudentstab
    {
        public DatabaseContext _context;
        public StudentstabRepo(DatabaseContext context)
        {
            _context = context;
        }
        public List<Studentstab>GetStudentstabs()
        {
            return _context.Studentstab.ToList();

        }
        public Studentstab GetStudentstab(int Id)
        {
            return _context.Studentstab.FirstOrDefault(st => st.Id == Id);
        }
        public void Create(Studentstab studentstab)
        {
            _context.Add(studentstab);
            _context.SaveChanges();
        }
        public void Update(Studentstab studentstab)
        {
            _context.Update(studentstab);
            _context.SaveChanges();
        }
    }
}
