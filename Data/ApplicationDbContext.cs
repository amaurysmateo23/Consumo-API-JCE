using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Tarea5.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Usuarios> usuarios{get;set;}
        public DbSet<Secretos> secretos{get;set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source=Secretos.db");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)    
          {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Usuarios>(entityTypeBuilder=>{
                // entityTypeBuilder.ToTable("Usuarios");
                entityTypeBuilder.Property(i=>i.UserName).HasMaxLength(100).HasDefaultValue(0);
                entityTypeBuilder.Property(i=>i.Cedula).HasMaxLength(14);
        });
        }
    }
}
