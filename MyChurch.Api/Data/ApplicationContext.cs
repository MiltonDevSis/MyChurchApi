using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyChurch.Api.Data.Mappings;
using MyChurch.Api.Domain.Models;

namespace MyChurch.Api.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}