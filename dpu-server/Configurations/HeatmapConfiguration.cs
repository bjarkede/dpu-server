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
                new Heatmap { HeatmapId = 1, Strength = 1},
                new Heatmap { HeatmapId = 2, Strength = 2},
                new Heatmap { HeatmapId = 3, Strength = 3},
                new Heatmap { HeatmapId = 4, Strength = 4},
                new Heatmap { HeatmapId = 5, Strength = 2},
                new Heatmap { HeatmapId = 6, Strength = 2},
                new Heatmap { HeatmapId = 7, Strength = 3},
                new Heatmap { HeatmapId = 8, Strength = 1},
                new Heatmap { HeatmapId = 9, Strength = 4},
                new Heatmap { HeatmapId = 10, Strength = 1}
                );
        }
    }
}
