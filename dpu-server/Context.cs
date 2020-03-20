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

        public DbSet<Referencepoint> Referencepoints { get; set; }

        public DbSet<Heatmap> Heatmaps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:fruitflyserver.database.windows.net,1433;Initial Catalog=FruitFly;Persist Security Info=False;User ID=dalleman;Password=Frugtflue1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Reference
            modelBuilder.Entity<Referencepoint>().HasKey(r => r.ReferencepointID);

            //Heatmap
            modelBuilder.Entity<Heatmap>().HasKey(h => h.HeatmapID);

            //Heatmap one to one relationship (One HeatmapID has a Referencepoint)
            modelBuilder.Entity<Heatmap>()
                .HasOne<Referencepoint>(H => H.Referencepoint)
                .WithOne(R => R.Heatmap)
                .HasForeignKey<Referencepoint>(R => R.HeatmapFK);
        }
    }
}
