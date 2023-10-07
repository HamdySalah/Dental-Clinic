using Microsoft.AspNetCore.Mvc;

namespace dental_clinic.Controllers
{
    public class sign_inController : Controller
    {
        [HttpGet]
        public IActionResult sign()
        {
            string usname = "";
            string pass = "";
            //ViewBag.username = usname;
            //ViewBag.pass = pass;
            return View();
        }

        [HttpPost]
        public IActionResult sign_post()
        {
            string usname = "";
            string pass = "";
            ViewBag.username = usname;
            ViewBag.pass = pass;
            return RedirectToAction("sign");
        }
    }
}
