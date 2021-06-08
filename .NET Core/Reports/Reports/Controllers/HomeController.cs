using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Reports.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Customer()
        {
            return View();
        }

        private DBCtx Context { get; }
        public HomeController(DBCtx _context)
        {
            this.Context = _context;
        }

        public IActionResult Index()
        {
            return View(this.Context.Customers.Take(10).ToList());
        }

        [HttpPost]
        public IActionResult Export(string GridHtml)
        {
            return File(System.Text.Encoding.ASCII.GetBytes(GridHtml), "application/vnd.ms-excel", "Grid.xls");
        }
    }
}
