using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysApp
{
    public class Connection : DbContext
    {
        public DbSet<ToyObj> Toys { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = @"Data Source = qmir-main;
                            Initial Catalog = ToysTest;
                            Integrated Security = true;
                            TrustServerCertificate = Yes;";

            optionsBuilder.UseSqlServer(path);

        }
    }
}
