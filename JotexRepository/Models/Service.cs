using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class Service:BaseEntity
	{
		public int ServiceId { get; set; }
		public string Name { get; set; }

		public string Details { get; set; }

		public string SecondaryDetail { get; set; }

		public string BottomTitle { get; set; }

		public string BottomInfo { get; set; }

		public string Image { get; set; }

		public string DownloadDocument { get; set; }

		public bool Status { get; set; }

		ICollection<Category> categories { get; set; }

		ICollection<ServiceFeature> ServiceFeature { get; set; }






	}
}
