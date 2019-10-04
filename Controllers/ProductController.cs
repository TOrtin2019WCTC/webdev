﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Client.Controllers
{
    public class ProductController : Controller
    {
        private Category c;

        // GET: /<controller>/
        public IActionResult Category() => View(c.CategoryName);

    }
}
