using System;
using System.Collections.Generic;
using System.Text;
using JotexRepository.Data;
using JotexRepository.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JotexRepository.Repos.CaseStudiesRepositories
{
	public class CaseStudiesRepository:ICaseStudiesRepository
	{
		private readonly JotexDbContext _context;

		public CaseStudiesRepository(JotexDbContext context)
		{
			_context = context;
		}
		public IEnumerable<CaseStudies> GetCaseStudies()
		{
			return _context.CaseStudies.Where(d => d.Status).ToList();
		}
	}
}
