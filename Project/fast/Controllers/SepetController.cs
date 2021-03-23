using fast.Filter;
using fast.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fast.Controllers
{
    [UserFilter]
    public class SepetController : Controller
    {
        private readonly Context _context;
        public SepetController(Context context)
        {
            _context = context;
        }
        public IActionResult Order()
        {
            var a = HttpContext.Session.GetString("mail");
            var deneme = _context.Sepets.Where(x => x.UserMail == a).ToList();            
            return View(deneme);
        }

        public async Task<IActionResult> Se(Sepet model)
        {
            if (HttpContext.Session.GetInt32("id").HasValue)
            {
                await _context.AddAsync(model);
                await _context.SaveChangesAsync();
                return Redirect("/Index/Index2");
            }
            return RedirectToAction("/Login/Index");

        }      
        public IActionResult Sil(int id)
        {      
                var depa = _context.Sepets.Find(id);
            _context.Sepets.Remove(depa);
            _context.SaveChanges();
                return RedirectToAction("Order");          
        }
        public IActionResult AllSil()
        {
            var a = HttpContext.Session.GetString("mail");
            var depa = _context.Sepets.Where(x => x.UserMail == a);
            _context.Sepets.RemoveRange(depa);
            _context.SaveChanges();
            return RedirectToAction("Order");
        }      
    }
}
