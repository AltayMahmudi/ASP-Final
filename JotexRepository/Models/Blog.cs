using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class Blog:BaseEntity
	{
		public int Id { get; set; }

		public string BlogTitle { get; set; }
		public string BlogText { get; set; }

		public string BlogSecondTitle { get; set; }
		public string BlogSecondText { get; set; }

		public string BlogImg { get; set; }
		public DateTime PostDate { get; set; }

		public Tag TAG { get; set; }

		public string Review { get; set; }
		public string ReviewerName { get; set; }
		public bool Status { get; set; }



		public BlogComments BlogComments { get; set; }




	}
}
