using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Zooline.Models;

namespace Zooline.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Especie> Especie { get; set; }
        public DbSet<Tour> Tour { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
