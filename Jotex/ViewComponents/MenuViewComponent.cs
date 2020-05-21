using AutoMapper;
using Jotex.Models;
using JotexRepository.InsuranceRepositories;
using JotexRepository.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.ViewComponents
{
	public class MenuViewComponent:ViewComponent
	{
		private readonly IMapper _mapper;
		private readonly IServiceRepository _serviceRepository;
		public MenuViewComponent(IMapper mapper, IServiceRepository serviceRepository)
		{
			_mapper = mapper;
			_serviceRepository = serviceRepository;
		}
		public IViewComponentResult Invoke() 
		{
			var services = _serviceRepository.GetServicesWithCategory();

			var model = _mapper.Map<IEnumerable<Service>,IEnumerable<ServiceViewModel>>(services);
			return View();
		}
	}
}
