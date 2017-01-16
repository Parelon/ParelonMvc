using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParelonCore.Controllers
{
    public class TerritoryController : Controller
    {
        // GET: Territory
        public ActionResult List()
        {
            return View();
        }

        public ActionResult _TerritoryItem()
        {
            return PartialView();
        }
    }
}