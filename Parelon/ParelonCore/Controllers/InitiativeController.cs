using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParelonCore.Controllers
{
    public class InitiativeController : Controller
    {
        public ActionResult Show() { return View(); }
        public ActionResult _Introduction() { return PartialView(); }
        public ActionResult _Draft() { return PartialView(); }
        public ActionResult _Actions() { return PartialView(); }
        public ActionResult _Authors(bool isAnonimous)
        {
            ViewBag.isAnonimous = isAnonimous;
            return PartialView();
        }
        public ActionResult _Policy() { return PartialView(); }
        public ActionResult _Keywords() { return PartialView(); }
        public ActionResult _DetailedData() { return PartialView(); }
        public ActionResult _Supporters(bool isAnonimous)
        {
            ViewBag.isAnonimous = isAnonimous;
            return PartialView();
        }
        public ActionResult _PotentialSupporters(bool isAnonimous)
        {
            ViewBag.isAnonimous = isAnonimous;
            return PartialView();
        }
        public ActionResult _Votes() { return PartialView(); }
        public ActionResult _Population(bool isAnonimous)
        {
            ViewBag.isAnonimous = isAnonimous;
            return PartialView();
        }

        public ActionResult List()
        {
            return PartialView();
        }

        public ActionResult _InitiativeItem()
        {
            return PartialView();
        }
    }
}