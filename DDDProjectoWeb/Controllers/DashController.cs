﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DDDProjectoWeb.Controllers
{
    public class DashController : Controller
    {
        public IActionResult Index()
        {            
            return View();
        }
    }
}