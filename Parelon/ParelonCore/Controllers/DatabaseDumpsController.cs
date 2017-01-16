using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ParelonCore.Controllers
{
    public class DatabaseDumpsController : Controller
    {
        // GET: DatabaseDumps
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                return View();
            else
                return RedirectToAction("Login", "Account");
        }
    }
}