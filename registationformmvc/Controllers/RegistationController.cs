using registationformmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace registationformmvc.Controllers
{
    public class RegistationController : Controller
    {
        // GET: Registation
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult reg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult reg(registation regi)
        {

            if (ModelState.IsValid)
                ViewBag.message = "registation sucessfuly ";
            return View(regi);
        }
    }
}