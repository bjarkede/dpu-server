﻿using dpu_server.DataLayer.Interfaces;
using dpu_server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpu_server.DataLayer.Repositories
{
    public class HeatmapRepository : CrudRepository<Heatmap>, IHeatmapRepository
    {
        private readonly FruitFlyContext _fruitFlyContext;
        public HeatmapRepository(FruitFlyContext fruitFlyContext) : base(fruitFlyContext)
        {
            _fruitFlyContext = fruitFlyContext;
        }

        public async Task<bool> DoesHeatmapExist(int heatmapId)
        {
            try
            {
                int count = await _fruitFlyContext.Heatmaps
                .AsNoTracking()
                .Where(h =>
                h.HeatmapID == heatmapId)
                .CountAsync();
                Console.WriteLine("Heatmapdata exists\n");
                return (count == 1) ? true : false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Heatmapdata does not exist\n", e);
                return false;
            }
        }

        public override async Task<List<Heatmap>> GetAllAsync(bool tracking = false)
        {
            try
            {
                List<Heatmap> heatmaps = await _fruitFlyContext.Heatmaps
                .Include(h => h.Referencepoint)
                .AsNoTracking()
                .ToListAsync();
                Console.WriteLine("Successfully retrieved a list of heatmapdata\n");
                return heatmaps;
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to retrieve a list of heatmapdata\n", e);
                return null;
            }
        }

        public override async Task<Heatmap> GetByIdAsync(int heatmapId)
        {
            try
            {
                Heatmap heatmap = await _fruitFlyContext.Heatmaps
                .Include(h => h.Referencepoint)
                .AsNoTracking()
                .SingleAsync(h => h.HeatmapID == heatmapId);
                Console.WriteLine($"Specified Heatmapdata with the heatmapId: {heatmapId} exists\n");
                return heatmap;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to retrieve a heatmap with the Id: {heatmapId}\n", e);
                return null;
            }
        }

        public async Task<bool> RemoveRangeAsync()
        {
            foreach (var id in _fruitFlyContext.Heatmaps.Select(e => e.HeatmapID))
            {
                var entity =  new Heatmap { HeatmapID = id };
                _fruitFlyContext.Heatmaps.Attach(entity);
                _fruitFlyContext.Heatmaps.Remove(entity);
            }

            return await _fruitFlyContext.SaveChangesAsync() > 0;
        }
    }
}
