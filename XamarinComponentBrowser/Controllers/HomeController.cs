using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ooui.AspNetCore;
using Xamarin.Forms;
using XamarinComponentBrowser.Models;
using XamarinComponentBrowser.Views.Home;

namespace XamarinComponentBrowser.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var page = new HomePage();
            var element = page.GetOouiElement();
            return new ElementResult(element, "Home Page");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
