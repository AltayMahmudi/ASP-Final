﻿using System;
using System.Collections.Generic;
using System.Text;
using JotexRepository.Data;
using JotexRepository.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JotexRepository.InsuranceRepositories
{
	public class ServiceRepository : IServiceRepository
	{
		private readonly JotexDbContext _context;

		public ServiceRepository(JotexDbContext context)
		{
			_context = context;
		}
		public IEnumerable<Service> GetServicesWithCategory()
		{
			return _context.services.Include("category").Where(d => d.Status).ToList();
		}
	}
}


