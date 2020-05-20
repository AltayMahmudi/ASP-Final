using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.Models
{
	public class CaseTabs:BaseEntity
	{
		public int CaseTabsId { get; set; }

		public string CaseTabTitle { get; set; }

		public string CaseTabText { get; set; }
		public CaseStudies caseStudies { get; set; }



	}
}
