using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Jotex.Models;
using JotexRepository.InsuranceRepositories;
using JotexRepository.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jotex.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IMapper _mapper;

        private readonly IServiceRepository _serviceRepository;
        public ServiceController(IMapper mapper, IServiceRepository serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }
        public IActionResult Index(int id)
        {
            var service = _serviceRepository.GetServicesById(id);
            if (service == null) return NotFound();

            var model = new ServiceListViewModel
            {
                Service = _mapper.Map<Service, ServiceViewModel>(service)
            };
            return View(model);
        }
        public IActionResult ServiceView()
        {
            return View();
        }

    }
}