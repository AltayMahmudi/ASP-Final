using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace JotexRepository.Data
{
    public class JotexDbContext:DbContext
	{
		public JotexDbContext(DbContextOptions<JotexDbContext> options):base(options) { }
	}
}
