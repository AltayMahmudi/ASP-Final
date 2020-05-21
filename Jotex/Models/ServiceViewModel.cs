using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
	public class ServiceViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public IList<CategoryViewModel> categoryViewModels { get; set; }
	}
}
