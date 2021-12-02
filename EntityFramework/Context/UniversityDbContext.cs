using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Context
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-9KVL4IOV\SQLEXPRESS01; Database=UniversityDB; Trusted_Connection=True;");
    }
}
