﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Jotex.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult BlogFullWidth()
        {
            return View();
        }

        public IActionResult BlogSingle()
        {
            return View();
        }
    }
}
