using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parelon.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                return View();
            else
                return RedirectToAction("Login", "Account", new { returnUrl = "" });
        }

        public ActionResult Policies()
        {
            return View();
        }

        public ActionResult EditPolicy()
        {
            return View();
        }

        public ActionResult Territories()
        {
            return View();
        }
        public ActionResult EditTerritory()
        {
            return View();
        }

        public ActionResult Topics()
        {
            return View();
        }

        public ActionResult EditTopic()
        {
            return View();
        }

        public ActionResult Members()
        {
            return View();
        }

        public ActionResult EditMember()
        {
            return View();
        }

        public ActionResult DatabaseDumps()
        {
            return View();
        }

        public ActionResult OtherConfigs()
        {
            return View();
        }
    }
}