using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Quiz4.Models;

namespace Quiz4.Data
{
    public class Quiz4Context : DbContext
    {
        public Quiz4Context (DbContextOptions<Quiz4Context> options)
            : base(options)
        {
        }

        public DbSet<Quiz4.Models.Movie> Movie { get; set; } = default!;
    }
}
