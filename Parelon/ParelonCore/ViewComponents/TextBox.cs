using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParelonCore.ViewComponents
{
    public class TextBox : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string title, string content, string titleClass, string contentClass)
        {
            ViewBag.Title = title;
            ViewBag.Subtitle = content;
            ViewBag.titleClass = titleClass;
            ViewBag.contentClass = contentClass;
            return View();
        }

    }
}
