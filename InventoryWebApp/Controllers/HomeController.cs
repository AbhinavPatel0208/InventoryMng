﻿using Microsoft.AspNetCore.Mvc;

namespace InventoryWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
