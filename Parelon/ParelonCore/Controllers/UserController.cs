using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParelonCore.Controllers
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