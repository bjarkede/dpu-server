﻿using dpu_server.Configurations;
using dpu_server.Models;
using Microsoft.EntityFrameworkCore;

namespace dpu_server
{
    public class FruitFlyContext : DbContext
    {
        public DbSet<Referencepoint> Referencepoints { get; set; }

        public DbSet<Heatmap> Heatmaps { get; set; }

        /*public FruitFlyContext(DbContextOptions<FruitFlyContext> optionsBuilder) : base(optionsBuilder)
        {

        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:fruitfly.database.windows.net,1433;Initial Catalog=fruitflydb;Persist Security Info=False;User ID=dalle;Password=Frugtflue1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Static data for testing purposes
            modelBuilder.ApplyConfiguration(new ReferencepointConfiguration());
            modelBuilder.ApplyConfiguration(new HeatmapConfiguration());
        }
    }
}
