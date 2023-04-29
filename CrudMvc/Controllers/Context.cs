using CrudMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMvc.Controllers
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options) { }
        public DbSet<People> People { get; set; }
    }
}
