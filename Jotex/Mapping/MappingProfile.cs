using AutoMapper;
using Jotex.Models;
using JotexRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Mapping
{
	public class MappingProfile:Profile
	{
		public MappingProfile() 
		{


			CreateMap<Service, ServiceViewModel>();

		}
	}
}
