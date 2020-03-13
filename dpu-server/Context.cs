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

        public DbSet<Reference> References { get; set; }

        public DbSet<Heatmap> Heatmaps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-5VIV2QMO\\FRUITFLY;Initial Catalog=FruitFly;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Reference

            modelBuilder.Entity<Reference>().HasKey(r => r.ReferenceID);

            // Heatmap

            modelBuilder.Entity<Heatmap>().HasKey(h => h.HeatmapID);

            // Heatmap has X and Y points, which are the reference points found in the reference table

            modelBuilder.Entity<Heatmap>()
                .HasOne<Reference>(r => r.Reference)
                .WithOne(h => h.Heatmap)
                .HasForeignKey<Reference>(r => r.X);

            modelBuilder.Entity<Heatmap>()
                .HasOne<Reference>(r => r.Reference)
                .WithOne(h => h.Heatmap)
                .HasForeignKey<Reference>(r => r.Y);

        }

        public IEnumerable<Heatmap> LoadEager()
        {
            var Heatmapdata = Heatmaps
                .Include(h => h.Reference)
                .ToList();

            return Heatmapdata;
        }
    }
}
