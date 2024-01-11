using Microsoft.EntityFrameworkCore;
using ND.AR.Project.BL.Entities;
using ND.AR.Project.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.AR.Project.DA
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            

        }

        public DbSet<User> Users { get; set; }
    }
}
