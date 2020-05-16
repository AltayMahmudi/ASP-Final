using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class Department
	{
		public int İd { get; set; }
		public int Name { get; set; }

		public ICollection<Service> Services { get; set; }
	}
}
