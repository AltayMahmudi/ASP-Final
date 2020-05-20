using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JotexRepository.Models
{
	public class CaseStudies:BaseEntity
	{

		public int CaseId { get; set; }
		[Required]
		public string CaseTitle { get; set; }
		[Required]
		public string CaseTextBold { get; set; }
		[Required]
		public string CaseText { get; set; }
		[Required]
		public string Caseİmage { get; set; }

		[Required]
		public string ClientName { get; set; }

		[Required]
		public DateTime Date { get; set; }
		[Required]
		public string Time { get; set; }
		[Required]
		public string Location { get; set; }
	
		public Category Category { get; set; }
	
		public TAG TAG { get; set; }
	
		public CaseTabs CaseTab { get; set; }

		public MultiCase multiCase { get; set; }



	}
}
