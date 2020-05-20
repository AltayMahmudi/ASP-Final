using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class Service:BaseEntity
	{
		public int ServiceId { get; set; }
		public string Title { get; set; }

		public string Details { get; set; }

		public string SecondaryDetail { get; set; }

		public string BottomTitle { get; set; }

		public string BottomInfo { get; set; }

		public string Image { get; set; }

		public string DownloadDocument { get; set; }

		ICollection<ServiceFeature> ServiceFeature { get; set; }






	}
}
