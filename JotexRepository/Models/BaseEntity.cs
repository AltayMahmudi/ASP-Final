using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JotexRepository.Models
{
    public class BaseEntity
	{
		public int Id  { get; set; }
		[Required]
		public DateTime CreatedAt { get; set; }
		[Required]
		public DateTime ModifiedAt { get; set; }
		[Required]
		public string CreatedBy { get; set; }
		[Required]
		public string ModifiedBy { get; set; }



	}
}
