using Parelon.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace Parelon.Controllers
{
    public class DraftController : Controller
    {
        // GET: Draft
        public ActionResult Show()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Edit(string text)
        {
            Document.instance = new Document(text);
            return RedirectToAction("Show", "Initiative");
        }

        public ActionResult Render()
        {
            return PartialView();
        }
    }
}