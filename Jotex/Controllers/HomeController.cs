﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Jotex.Models;

namespace Jotex.Controllers
{
	public class HomeController : Controller
	{
	

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult AboutUs()
		{
			return View();
		}
		public IActionResult Contact()
		{
			return View();
		}
		public IActionResult FAQ()
		{
			return View();
		}


	}
}
