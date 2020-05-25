using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class Subscription:BaseEntity
	{
		public string Email { get; set; }

		public bool Status { get; set; }

	}
}
