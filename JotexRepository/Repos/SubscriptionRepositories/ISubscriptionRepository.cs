using System;
using System.Collections.Generic;
using System.Text;
using JotexRepository.Data;
using JotexRepository.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace JotexRepository.Repos.SubscriptionRepositories
{
	public interface ISubscriptionRepository
	{
		IEnumerable<Subscription> GetSubscriptions();
	}
}
