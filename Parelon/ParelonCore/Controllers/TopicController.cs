using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParelonCore.Controllers
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