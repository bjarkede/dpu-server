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
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-5VIV2QMO\\FRUITFLY;Initial Catalog=FruitFly;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Reference

            modelBuilder.Entity<Reference>().HasKey(r => r.ReferenceID);

            // Heatmap has referencepoints X and Y.

            modelBuilder.Entity<Heatmap>().HasKey(h => h.HeatmapID);

            modelBuilder.Entity<Heatmap>()
                .HasOne<Reference>(h => h.X)
                .WithOne(r => r.Heatmap)
                .HasForeignKey(r => r.ReferenceX);

            modelBuilder.Entity<Heatmap>()
                .HasOne<Reference>(h => h.Y)
                .WithOne(r => r.Heatmap)
                .HasForeignKey(r => r.ReferenceY);
        }

    }
}
