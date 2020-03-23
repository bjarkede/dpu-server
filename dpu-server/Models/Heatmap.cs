using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dpu_server.Models
{
    public class Heatmap
    {
        public int HeatmapID { get; set; }

        public float Strength { get; set; }

        public Referencepoint Referencepoint { get; set; }
    }
}
