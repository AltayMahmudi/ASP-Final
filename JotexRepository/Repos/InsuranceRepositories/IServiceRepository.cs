﻿using JotexRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JotexRepository.InsuranceRepositories
{
	public interface IServiceRepository
	{
		Service GetServicesById(int id);
	}
}
