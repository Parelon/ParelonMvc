using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parelon.Controllers
{
    public class AttachmentController : Controller
    {
        // GET: Resource
        public ActionResult List()
        {
            return PartialView();
        }

        public ActionResult _AttachmentItem()
        {
            return PartialView();
        }
    }
}