using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parelon.Controllers
{
    public class TopicController : Controller
    {
        // GET: TopicController
        public ActionResult List()
        {
            return View();
        }

        public ActionResult _TopicItem()
        {
            return PartialView();
        }
    }
}