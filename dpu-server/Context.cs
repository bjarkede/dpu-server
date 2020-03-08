using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dpu_server.Models;
using Microsoft.EntityFrameworkCore;

namespace dpu_server
{
    public class MyDbContext : DbContext
    {
        //public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=172.25.129.88;Initial Catalog=Reference;Persist Security Info=True;User ID=sa;Password='F?G2Qt8E.;<4vzuV';");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Reference

            modelBuilder.Entity<Reference>().HasKey(r => r.ReferenceID);

        }

    }
}
