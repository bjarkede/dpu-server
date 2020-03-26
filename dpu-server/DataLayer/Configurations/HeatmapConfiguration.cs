using dpu_server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace dpu_server.Configurations
{
    public class HeatmapConfiguration : IEntityTypeConfiguration<Heatmap>
    {
        public void Configure(EntityTypeBuilder<Heatmap> entity)
        {
            var rand = new Random();
            //250 heatmapdata for testing
            for (int i = 1; i < 250; i++)
            {
                entity.HasData(
                    new Heatmap
                    {
                        HeatmapID = i,
                        Strength = rand.Next(1,10)
                    }
                    );
            }
        }
    }
}
