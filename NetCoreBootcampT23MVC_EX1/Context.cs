using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NetCoreBootcampT23MVC_EX1
{
    public class ContextBase:DbContext
    {
        public const string DEFAULT = "server=localhost;port=3322;user id=root;password=admin;database=ContextMVC";
        public ContextBase():base() { }
        public ContextBase([NotNull] DbContextOptions options) : base(options) { }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(DEFAULT, new MariaDbServerVersion(new Version(10, 5, 10)));
                 

            base.OnConfiguring(optionsBuilder);
        }

    }
    public class Context : ContextBase,IBaseEx1
    {
        public Context() : base() { }
        public Context([NotNull] DbContextOptions options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
    }
    public interface IBaseEx1
    {
        public DbSet<Cliente> Clientes { get; set; }
        public int SaveChanges();
    }
}
