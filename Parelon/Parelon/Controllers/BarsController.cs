using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parelon.Core;

namespace Parelon.Controllers
{
    public class BarsController : Controller
    {
        public ActionResult TitleBar(string title, string subtitle)
        {
            ViewBag.Title = title;
            ViewBag.Subtitle = subtitle;
            return PartialView();
        }

        public ActionResult GoPrev()
        {
            ViewContext prev = History.getPrev();
            if (prev != null)
                return View(prev.View);
            else return null;
        }

        public ActionResult GoNext()
        {
            ViewContext next = History.getNext();
            if(next != null)
                return View(next.View);
            else return null;
        }
        
        public ActionResult StatusBar()
        {
            return PartialView();
        }

        public ActionResult MessagesBar()
        {
            return PartialView();
        }

        public ActionResult AmendmentBar()
        {
            return PartialView();
        }
    }
}
