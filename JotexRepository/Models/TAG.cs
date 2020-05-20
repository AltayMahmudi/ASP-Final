using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class TAG:BaseEntity
	{
		public int TagId { get; set; }

		public int TagName { get; set; }

		public CaseStudies CaseStudies { get; set; }
	}
}
