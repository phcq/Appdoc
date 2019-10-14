using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App4.Models;
using Microsoft.EntityFrameworkCore;

namespace App4.Models
{
    public class App4Context : DbContext
    {
        public App4Context (DbContextOptions<App4Context> options)
            : base(options)
        {
        }

        public DbSet<Pacient> Pacient { get; set; }
        public DbSet<Disease> Disease { get;set; }
    }
}
