using fast.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fast.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Michelangelo()
        {
            return View();
        }
        public IActionResult Vincent()
        {
            return View();
        }
        public IActionResult Claude()
        {
            return View();
        }
        public IActionResult Leonardo()
        {
            return View();
        }
        public IActionResult Pablo()
        {
            return View();
        }
        public IActionResult Salvador()
        {
            return View();
        }        
    }
}
