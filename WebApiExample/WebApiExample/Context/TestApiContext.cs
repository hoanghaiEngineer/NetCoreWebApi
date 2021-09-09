using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.Models;

namespace WebApiExample.Context
{
    public class TestApiContext : DbContext
    {
        public TestApiContext(DbContextOptions<TestApiContext> options)
            : base(options)
        {
        }

        public DbSet<UserModel> TblUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
