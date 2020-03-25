using dpu_server.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dpu_server.ServiceLayer.Interfaces
{
    public interface IHeatmapService : ICrudService<Heatmap>
    {
        Task<bool> DoesHeatmapExist(int heatmapId);
    }
}
