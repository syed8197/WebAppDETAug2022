using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Filters;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		//public IActionResult Index()
		//{
		//	return View();
		//}
        public IActionResult Helo(string name, string loc, string contact)
        {
            //string myname = "sindhu";
            ViewBag.UserName = name;
            ViewBag.Location = loc;
            ViewBag.Contact = contact;
            return View();
        }
		[MyLog]
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