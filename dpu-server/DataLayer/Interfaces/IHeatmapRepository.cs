using dpu_server.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dpu_server.DataLayer.Interfaces
{
    public interface IHeatmapRepository : ICrudRepository<Heatmap>
    {
        Task<bool> DoesHeatmapExist(int heatmapId);
        Task<bool> RemoveRangeAsync();
    }
}
