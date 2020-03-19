using System;
using System.Collections.Generic;

namespace dpu_server.Models
{
	public class Referencepoint
	{
		public int ReferencepointID { get; set; }

		public int Category { get; set; } // ClusterID

		public int RSSI1 { get; set; }

		public int RSSI2 { get; set; }

		public int RSSI3 { get; set; }

		public int X { get; set; }

		public int Y { get; set; }

	}
}