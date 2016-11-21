using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parelon.Controllers
{
    public class UserController : Controller
    {
        // GET: Users
        public ActionResult LittleBox()
        {
            return PartialView();
        }

        public ActionResult AuthorBox()
        {
            return PartialView();
        }
    }
}