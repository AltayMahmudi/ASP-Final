using System;
using System.Collections.Generic;
using System.Text;
using JotexRepository.Data;
using JotexRepository.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JotexRepository.Repos.SubscriptionRepositories
{
	public class SubscriptionRepository : ISubscriptionRepository
	{
		private readonly JotexDbContext _context;

		public SubscriptionRepository(JotexDbContext context)
		{
			_context = context;
		}
		public IEnumerable<Subscription> GetSubscriptions()
		{
			return _context.Subscriptions.Where(d => d.Status).ToList();
		}
	}
}
