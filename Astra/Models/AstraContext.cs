using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Astra.Models
{
    public class AstraContext : DbContext
    {
        public AstraContext(DbContextOptions<AstraContext> options)
            :base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Useres { get; set; }
    }
}
