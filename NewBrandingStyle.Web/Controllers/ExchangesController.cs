﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Controllers
{
    public class ExchangesController : Controller
    {
        public IActionResult Display(int id)
        {
            return View();
        }
    }
}
