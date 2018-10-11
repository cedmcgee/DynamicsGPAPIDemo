using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DynamicsGPJDFAPI.Models;

namespace DynamicsGPJDFAPI.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlDbContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Entities.Pm00300> Pm00300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public SqlDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
