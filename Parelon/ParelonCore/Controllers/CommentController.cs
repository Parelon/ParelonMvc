using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Parelon.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult List()
        {
            return PartialView();
        }

        public ActionResult _CommentItem()
        {
            return PartialView();
        }
    }
}