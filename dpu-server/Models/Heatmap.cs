using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dpu_server.Models
{
    public class Heatmap
    {
        public int HeatmapId { get; set; }

        public int Strength { get; set; }

        public Referencepoint Referencepoint { get; set; }
    }
}
