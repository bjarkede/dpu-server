using System;
using System.Collections.Generic;

namespace dpu_server.Models
{
    public class Heatmap
    {
        public int HeatmapID { get; set; }

        public int Strength { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int ReferenceX { get; set; }

        public int ReferenceY { get; set; }

        public Reference Reference { get; set; }
    }
}
