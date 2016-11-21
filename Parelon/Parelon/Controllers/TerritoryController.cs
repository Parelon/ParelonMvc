using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parelon.Controllers
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