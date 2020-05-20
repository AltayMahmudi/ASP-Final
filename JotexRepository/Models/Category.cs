using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class Category:BaseEntity
	{
		public int CategoryId { get; set; }

		public int CategoryTitle { get; set; }
	}
}
