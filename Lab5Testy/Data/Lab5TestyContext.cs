using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab5Testy;

namespace Lab5Testy.Data
{
    public class Lab5TestyContext : DbContext
    {
        public Lab5TestyContext (DbContextOptions<Lab5TestyContext> options)
            : base(options)
        {
        }

        public DbSet<Lab5Testy.Task> Task { get; set; } = default!;
    }
}
