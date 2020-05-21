using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class MultiCase
	{
		public int Id { get; set; }
		public int CaseId { get; set; }
		public string MultiCaseTitle { get; set; }
		public string MultiCaseSecondary { get; set; }

		public string MulticasePicture { get; set; }

		public CaseStudies caseStudies { get; set; }
	}
}
