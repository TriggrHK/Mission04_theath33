﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission4_IS413.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mission4_IS413.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GradeCalc()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GradeCalc(GradeCalcModel model)
        {
            return View();
        }
    }
}
