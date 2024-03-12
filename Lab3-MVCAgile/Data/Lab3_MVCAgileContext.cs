using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab3_MVCAgile.Models;

namespace Lab3_MVCAgile.Data
{
    public class Lab3_MVCAgileContext : DbContext
    {
        public Lab3_MVCAgileContext (DbContextOptions<Lab3_MVCAgileContext> options)
            : base(options)
        {
        }

        public DbSet<Lab3_MVCAgile.Models.Movie> Movie { get; set; } = default!;
    }
}
