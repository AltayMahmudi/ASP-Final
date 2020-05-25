using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JotexRepository.Models
{
    public class BaseEntity
	{
		public int Id  { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime ModifiedAt { get; set; }
		public string CreatedBy { get; set; }
		public string ModifiedBy { get; set; }



	}
}
