﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parelon.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        public ActionResult _TextBox(string Title, string Content, string titleClass, string contentClass)
        {
            ViewBag.Title = Title;
            ViewBag.Content = Content;
            ViewBag.titleClass = titleClass;
            ViewBag.contentClass = contentClass;
            return PartialView();
        }
        public ActionResult _GenericBox(string Title, string Content, string titleClass, string contentClass)
        {
            ViewBag.Title = Title;
            ViewBag.Content = Content;
            ViewBag.titleClass = titleClass;
            ViewBag.contentClass = contentClass;
            return PartialView();
        }
    }
}