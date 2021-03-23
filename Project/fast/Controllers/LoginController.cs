using fast.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fast.Controllers
{
    public class LoginController : Controller
    {
        private readonly Context _context;
        public LoginController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Gir(string email, string sifre)
        {
            var user = _context.Admins.FirstOrDefault(x => x.Email.Equals(email) && x.Sifre.Equals(sifre));
            if (user != null)
            {
                HttpContext.Session.SetInt32("id", user.AdminID);
                HttpContext.Session.SetString("fullname", user.Kullanici);
                HttpContext.Session.SetString("mail", user.Email);
                return Redirect("/Index/Index2");
            }
            return Redirect("Index");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/Index/Index2");
        }
        public IActionResult Register()
        {
            return View();
        }
        public async Task<ActionResult> SignUp(Admin a)
        {
            await _context.AddAsync(a);
            await _context.SaveChangesAsync();
            return Redirect("Index");
        }
        public IActionResult Forgot()
        {
            return View();
        }
        public IActionResult Sor(string kullanici,string isim,string soyad)
        {
            var aas = _context.Admins.FirstOrDefault(x => x.Kullanici.Equals(kullanici) && x.Name.Equals(isim)&&x.Surname.Equals(soyad));
            if (aas != null)
            {
                var seri = _context.Admins.Where(x => x.Kullanici == kullanici).ToList();
                return View(seri);
            }
            else
            {
                ViewData["Hata"] = "Yanlış Yoldasın";
                return View();
            }           
        }
    }
}
