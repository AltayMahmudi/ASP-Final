using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JotexRepository.Models
{
	public class ServiceDetail:BaseEntity
	{
		public int ServiceId { get; set; }

		//[Required]
		//public decimal PriceMin { get; set; }

		//[Required]
		//public decimal PriceMax { get; set; }

		[Required]
		public int GracePeriod { get; set; }

		[Required]
		public int SupportHour { get; set; }

		[Required]
		public bool IsPolicyModificationOnline { get; set; }

		public Service Service { get; set; }


	}
}
