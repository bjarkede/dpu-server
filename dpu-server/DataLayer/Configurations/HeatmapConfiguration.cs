using dpu_server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace dpu_server.Configurations
{
    public class HeatmapConfiguration : IEntityTypeConfiguration<Heatmap>
    {
        public void Configure(EntityTypeBuilder<Heatmap> entity)
        {
            entity.HasData(
                new Heatmap { HeatmapID = 1, Strength = 1},
                new Heatmap { HeatmapID = 2, Strength = 2},
                new Heatmap { HeatmapID = 3, Strength = 3},
                new Heatmap { HeatmapID = 4, Strength = 4},
                new Heatmap { HeatmapID = 5, Strength = 2},
                new Heatmap { HeatmapID = 6, Strength = 2},
                new Heatmap { HeatmapID = 7, Strength = 3},
                new Heatmap { HeatmapID = 8, Strength = 1},
                new Heatmap { HeatmapID = 9, Strength = 4},
                new Heatmap { HeatmapID = 10, Strength = 1}
                );
        }
    }
}
