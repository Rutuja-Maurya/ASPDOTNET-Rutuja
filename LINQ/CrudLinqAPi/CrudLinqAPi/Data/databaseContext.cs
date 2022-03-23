using CrudLinqAPi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudLinqAPi.Data
{
    public class databaseContext:DbContext
    {
        public databaseContext(DbContextOptions<databaseContext> options) : base(options)
        {
        }
        public DbSet<Teacher> Teacher{ get; set; }
    }
}
