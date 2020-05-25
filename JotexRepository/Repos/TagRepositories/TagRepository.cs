using System;
using System.Collections.Generic;
using System.Text;
using JotexRepository.Data;
using JotexRepository.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JotexRepository.Repos.TagRepositories
{
	public class TagRepository : ITagRepository
	{
		private readonly JotexDbContext _context;

		public TagRepository(JotexDbContext context)
		{
			_context = context;
		}
		public IEnumerable<Tag> GetTags()
		{
			return _context.Tags.Where(d => d.Status).ToList();
		}
	}
}
