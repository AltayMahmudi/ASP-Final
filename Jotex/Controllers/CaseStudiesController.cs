﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Jotex.Controllers
{
    public class CaseStudiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CaseStudies()
        {
            return View();
        }
        public IActionResult CaseStudiesSingle()
        {
            return View();
        }
    }
}