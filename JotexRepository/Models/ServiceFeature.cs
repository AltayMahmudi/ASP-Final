using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class ServiceFeature : BaseEntity
	{
		public string Title { get; set; }

		public string Subtitle { get; set; }

		public string Icon { get; set; }

		ICollection<Service> services { get; set; }

	}
}
