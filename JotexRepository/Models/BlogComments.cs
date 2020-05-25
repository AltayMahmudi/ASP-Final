using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class BlogComments
	{
		public int CommentId { get; set; }

		public string UserName { get; set; }
		public DateTime CommentDate { get; set; }
		public string Comment { get; set; }
	}
}
