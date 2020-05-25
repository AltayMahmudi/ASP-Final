using System;
using System.Collections.Generic;
using System.Text;
using JotexRepository.Data;
using JotexRepository.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JotexRepository.TestimonialRepositories
{
	public class  TestimonialRepository : ITestimonialRepository
	{
		private readonly JotexDbContext _context;

		public TestimonialRepository(JotexDbContext context)
		{
			_context = context;
		}
		public IEnumerable<Testimonial> GetTestimonials()
		{
			return _context.Testimonials.Where(d => d.Status).ToList();
		}
	}
}
