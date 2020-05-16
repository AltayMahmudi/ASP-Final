using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class Service
	{
		public int İd { get; set; }

		public int Departmentİd { get; set; }
		public string Name { get; set; }
		public Department Department { get; set; }
	}
}
