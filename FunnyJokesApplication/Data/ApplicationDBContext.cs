using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FunnyJokesApplication.Models;

namespace FunnyJokesApplication.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<FunnyJokesApplication.Models.Jokes> Jokes { get; set; } = default!;
    }
}
