using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DynamicsGPAPI.Entities;

namespace DynamicsGPAPI.Entities
{
    public class DynamicsJDFDbContext : DbContext
    {
        public DbSet<Pm00300> Pm00300 { get; set; }
        public DynamicsJDFDbContext() { }
        public DynamicsJDFDbContext(DbContextOptions<DynamicsJDFDbContext> options) : base(options) { }
    }
}
