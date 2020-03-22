using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dpu_server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace dpu_server.Configurations
{
    public class ReferencepointConfiguration : IEntityTypeConfiguration<Referencepoint>
    {
        public void Configure(EntityTypeBuilder<Referencepoint> entity)
        {
            entity.HasData(
                new Referencepoint { ReferencepointId = 1, Category = 1, RSSI1 = 1, RSSI2 = 1, RSSI3 = 5, X = 1, Y = 1, HeatmapId = 1 },
                new Referencepoint { ReferencepointId = 2, Category = 2, RSSI1 = 2, RSSI2 = 2, RSSI3 = 3, X = 2, Y = 2, HeatmapId = 2 },
                new Referencepoint { ReferencepointId = 3, Category = 3, RSSI1 = 3, RSSI2 = 3, RSSI3 = 5, X = 3, Y = 3, HeatmapId = 3 },
                new Referencepoint { ReferencepointId = 4, Category = 4, RSSI1 = 4, RSSI2 = 2, RSSI3 = 3, X = 4, Y = 4, HeatmapId = 4 },
                new Referencepoint { ReferencepointId = 5, Category = 5, RSSI1 = 5, RSSI2 = 6, RSSI3 = 3, X = 5, Y = 5, HeatmapId = 5 },
                new Referencepoint { ReferencepointId = 6, Category = 1, RSSI1 = 1, RSSI2 = 2, RSSI3 = 1, X = 6, Y = 6, HeatmapId = 6 },
                new Referencepoint { ReferencepointId = 7, Category = 2, RSSI1 = 2, RSSI2 = 5, RSSI3 = 3, X = 7, Y = 7, HeatmapId = 7 },
                new Referencepoint { ReferencepointId = 8, Category = 3, RSSI1 = 3, RSSI2 = 2, RSSI3 = 3, X = 8, Y = 8, HeatmapId = 8 },
                new Referencepoint { ReferencepointId = 9, Category = 2, RSSI1 = 2, RSSI2 = 4, RSSI3 = 3, X = 9, Y = 9, HeatmapId = 9 },
                new Referencepoint { ReferencepointId = 10, Category = 2, RSSI1 = 2, RSSI2 = 3, RSSI3 = 2, X = 10, Y = 10, HeatmapId = 10 }
                );
        }
    }
}
