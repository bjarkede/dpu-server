using dpu_server.DataLayer.Interfaces;
using dpu_server.Models;
using dpu_server.ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dpu_server.ServiceLayer.Services
{
    public class HeatmapService : CrudService<Heatmap>, IHeatmapService
    {
        private readonly IHeatmapRepository _heatmapRepository;
        public HeatmapService(IHeatmapRepository heatmapRepository) : base(heatmapRepository)
        {
            _heatmapRepository = heatmapRepository;
        }
        public async Task<bool> DoesHeatmapExist(int heatmapId)
        {
            return await _heatmapRepository.DoesHeatmapExist(heatmapId);
        }

        public async Task<bool> RemoveRangeAsync()
        {
            return await _heatmapRepository.RemoveRangeAsync();
        }

    }
}
