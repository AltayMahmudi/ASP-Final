using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class Testimonial:BaseEntity
	{
		public int Testimonalİd { get; set; }
		public string Review { get; set; }
		public string Author { get; set; }

		public string AuthorTitle { get; set; }

	}
}
