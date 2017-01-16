using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParelonCore.Controllers
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