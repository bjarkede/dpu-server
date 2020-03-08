using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dpu_server.Models
{
	public class Reference
	{
		[Required]
		public int ReferenceID { get; set; }

		[Required]
		public int RSSI1 { get; set; }

		[Required]
		public int RSSI2 { get; set; }

		[Required]
		public int RSSI3 { get; set; }

		[Required]
		public int X { get; set; }

		[Required]
		public int Y { get; set; }

	}
}