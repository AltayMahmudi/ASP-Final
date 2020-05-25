using System;
using System.Collections.Generic;
using System.Text;
using JotexRepository.Data;
using JotexRepository.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JotexRepository.Repos.Blogs
{
	

		public interface IBlogRepository
		{
			IEnumerable<Blog> GetBlogs();
		}
	
}
