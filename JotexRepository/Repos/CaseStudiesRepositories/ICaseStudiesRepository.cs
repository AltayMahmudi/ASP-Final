using System;
using System.Collections.Generic;
using System.Text;
using JotexRepository.Data;
using JotexRepository.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JotexRepository.Repos.CaseStudiesRepositories
{
	public interface ICaseStudiesRepository
	{
		IEnumerable<CaseStudies> GetCaseStudies();
	}
}
