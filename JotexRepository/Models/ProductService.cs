using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class ProductService
	{
		public int Id { get; set; }
		public int ServiceId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Detailed { get; set; }
		public Decimal Payment { get; set; }

		public string GracePeriod { get; set; }

		public bool PolicyModification  { get; set; }
		public int NumberOfPeople { get; set; }

		public string Location { get; set; }

		public ICollection<ProductServicePhoto> Photos { get; set; }
	}
}
