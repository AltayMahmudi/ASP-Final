using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class Tag:BaseEntity
	{
		public int TagId { get; set; }

		public int TagName { get; set; }
		public bool Status { get; set; }

		public CaseStudies CaseStudies { get; set; }



	}
}
