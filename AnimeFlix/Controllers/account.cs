using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace AnimeFlix.Controllers
{
    public class account : Controller
    {
        [HttpGet]
        public IActionResult admin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult admin(string email,string pass)
        {
            if(email == "admin@admin.com" && pass == "admin")
            {
                HttpContext.Session.SetString("admin", "admin");
                return RedirectToAction("index","Home");
            }
            else
            {
                TempData["admin"] = "noadmin";
            }
            return Ok();
        }
        [HttpGet]
        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("index", "Home");
        }
    }
}
