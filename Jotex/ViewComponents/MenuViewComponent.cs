using AutoMapper;
using Jotex.Models;
using JotexRepository.InsuranceRepositories;
using JotexRepository.TestimonialRepositories;
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
		private readonly ServiceRepository _serviceRepository;
		public MenuViewComponent(IMapper mapper, ServiceRepository serviceRepository)
		{
			_mapper = mapper;
			_serviceRepository = serviceRepository;
		}
		public IViewComponentResult Invoke() 
		{
			var services = _serviceRepository.GetServices();

			var model = _mapper.Map<IEnumerable<Service>,IEnumerable<ServiceViewModel>>(services);
			return View(model);

		}
	}
}
