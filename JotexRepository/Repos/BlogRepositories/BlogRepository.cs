using System;
using System.Collections.Generic;
using System.Text;
using JotexRepository.Data;
using JotexRepository.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JotexRepository.Repos.Blogs
{
	public class BlogRepository:IBlogRepository
	{

		private readonly JotexDbContext _context;

		public BlogRepository(JotexDbContext context)
		{
			_context = context;
		}
		public IEnumerable<Blog> GetBlogs()
		{
			return _context.Blogs.Where(d => d.Status).ToList();
		}
	}
	}
