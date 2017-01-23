using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParelonCore.ViewComponents
{
    public class TitleBar : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string title, string subtitle)
        {
            ViewBag.Title = title;
            ViewBag.Subtitle = subtitle;

            return View();
        }

    }
}
