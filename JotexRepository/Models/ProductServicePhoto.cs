using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class ProductServicePhoto
	{
		public int Id { get; set; }
		public int ProductServiceId { get; set; }
		public string İmage { get; set; }

		public ProductService ProductService { get; set; }
	}
}
