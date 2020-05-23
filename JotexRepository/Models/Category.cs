using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class Category:BaseEntity
	{

		public int CategoryTitle { get; set; }

		public Service service { get; set; }


	}
}
