using System;
using System.Collections.Generic;

namespace dpu_server.Models
{
    public class Heatmap
    {
        public int HeatmapID { get; set; }

        public int Strength { get; set; }

        public Reference Y { get; set; }
        public Reference X { get; set; }
        public Reference Reference { get; set; }
    }
}
