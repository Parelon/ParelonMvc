using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParelonCore.Controllers
{
    public class WizardController : Controller
    {
        public ActionResult Start ( )
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Login", "Account", new { ReturnUrl = "~/Wizard/Start" });
            else
                return View();
        }

        [HttpGet]
        public ActionResult AddInterrogation ( )
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Login", "Account", new { ReturnUrl = "~/Wizard/Start" });
            else
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void AddInterrogation ( int i )
        {
        }

        [HttpGet]
        public ActionResult AddMotion ( )
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Login", "Account", new { ReturnUrl = "~/Wizard/Start" });
            else
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void AddMotion ( int i )
        {
        }

        [HttpGet]
        public ActionResult AddBill ( )
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Login", "Account", new { ReturnUrl = "~/Wizard/Start" });
            else
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void AddBill ( int i )
        {
        }

        [HttpGet]
        public ActionResult AddTemplate ( )
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Login", "Account", new { ReturnUrl = "~/Wizard/Start" });
            else
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void AddTemplate ( int i )
        {
        }

        [HttpGet]
        public ActionResult AddIssue ( )
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Login", "Account", new { ReturnUrl = "~/Wizard/Start" });
            else
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void AddIssue ( string problemTitle, string problemAbstract, string problemDescription,
            string problemAim, string problemKeywords, string problemPolicy )
        {
        }

        [HttpGet]
        public ActionResult AddInitiative ( )
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Login", "Account", new { ReturnUrl = "~/Wizard/Start" });
            else
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void AddInitiative ( string problemTitle, string problemAbstract, string problemDescription,
            string problemAim, string problemKeywords, string problemPolicy )
        {
        }
    }
}