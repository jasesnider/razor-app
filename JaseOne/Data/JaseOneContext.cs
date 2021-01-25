using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JaseOne.Models;

namespace JaseOne.Data
{
    public class JaseOneContext : DbContext
    {
        public JaseOneContext (DbContextOptions<JaseOneContext> options)
            : base(options)
        {
        }

        public DbSet<JaseOne.Models.Movie> Movie { get; set; }
    }
}
