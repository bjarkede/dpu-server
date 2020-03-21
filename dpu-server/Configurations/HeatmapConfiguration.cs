using dpu_server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace dpu_server.Configurations
{
    public class HeatmapConfiguration : IEntityTypeConfiguration<Heatmap>
    {
        public void Configure(EntityTypeBuilder<Heatmap> entity)
        {


        }
    }
}
