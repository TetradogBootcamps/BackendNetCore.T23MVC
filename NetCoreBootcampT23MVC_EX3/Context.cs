using Microsoft.EntityFrameworkCore;
using NetCoreBootcampT23MVC_EX3.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NetCoreBootcampT23MVC_EX3
{
    public class Context:DbContext
    {
        public const string DEFAULT = "server=localhost;port=3322;user id=root;password=admin;database=ContextMVC";
        public Context():base() { }
        public Context([NotNull] DbContextOptions options) : base(options) { }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Cientifico> Cientificos { get; set; }
        public DbSet<AsignadoA> AsignacionesProyectos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(DEFAULT, new MariaDbServerVersion(new Version(10, 5, 10)));
                 

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AsignadoA>().HasKey(nameof(AsignadoA.CientificoId),nameof(AsignadoA.ProyectoId));
        }
    }
}
