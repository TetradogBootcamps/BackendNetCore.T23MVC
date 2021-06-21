using Microsoft.EntityFrameworkCore;
using NetCoreBootcampT23MVC_EX1;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NetCoreBootcampT23MVC_EX2
{
    public class Context:NetCoreBootcampT23MVC_EX1.Context
    {

        public Context():base() { }
        public Context([NotNull] DbContextOptions options) : base(options) { }
        public DbSet<Video> Videos { get; set; }

    }
}
