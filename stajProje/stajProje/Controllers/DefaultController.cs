﻿using Microsoft.AspNetCore.Mvc;

namespace stajProje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
