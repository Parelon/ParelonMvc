using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParelonCore.Controllers
{
    public class AssemblyController : Controller
    {
        public ViewResult Introduction()
        {
            return View();
        }

        public ViewResult LeggiScrivi()
        {
            return View();
        }
    }
}