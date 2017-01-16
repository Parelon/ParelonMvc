using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParelonCore.Controllers
{
    public class IssueController : Controller
    {
        public ActionResult ShowDiscussion ( ) { return View(); }
        public ActionResult ShowAct ( ) { return View(); }
        public ActionResult _Introduction ( ) { return PartialView(); }
        public ActionResult _Actions ( ) { return PartialView(); }
        public ActionResult _Authors ( bool isAnonimous )
        {
            ViewBag.isAnonimous = isAnonimous;
            return PartialView();
        }
        public ActionResult _Initiatives ( ) { return PartialView(); }
        public ActionResult _Policy ( ) { return PartialView(); }
        public ActionResult _Keywords ( ) { return PartialView(); }
        public ActionResult _DetailedData ( ) { return PartialView(); }
        public ActionResult _Supporters ( bool isAnonimous )
        {
            ViewBag.isAnonimous = isAnonimous;
            return PartialView();
        }
        public ActionResult _Population ( bool isAnonimous )
        {
            ViewBag.isAnonimous = isAnonimous;
            return PartialView();
        }

        public ActionResult List ( )
        {
            return View();
        }

        public ActionResult _IssueItem ( )
        {
            return PartialView();
        }
    }
}