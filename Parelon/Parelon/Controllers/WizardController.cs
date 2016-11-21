using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parelon.Controllers
{
    public class WizardController : Controller
    {
        // GET: Wizard
        public ActionResult Start()
        {
            if (!Request.IsAuthenticated)
                return RedirectToAction("Login", "Account", new { ReturnUrl = "~/Wizard/Start" });
            else
                return View();
        }
    }
}