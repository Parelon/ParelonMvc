using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parelon.Controllers
{
    public class VoteController : Controller
    {
        public ActionResult VoteNow()
        {
            if (!Request.IsAuthenticated)
                return RedirectToAction("Login", "Account", new { ReturnUrl = "~/Vote/VoteNow" });
            else
                return View();
        }

        public ActionResult _VoteBox ( int initiativeId )
        {
            ViewBag.initiativeId = initiativeId;
            return PartialView();
        }
    }
}