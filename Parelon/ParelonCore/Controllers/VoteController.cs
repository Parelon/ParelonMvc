using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParelonCore.Controllers
{
    public class VoteController : Controller
    {
        public ActionResult VoteNow()
        {
            if (!User.Identity.IsAuthenticated)
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