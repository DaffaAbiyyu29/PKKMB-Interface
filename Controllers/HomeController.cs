using Microsoft.AspNetCore.Mvc;
using PKKMB_Interface.Models;
using System.Diagnostics;

namespace PKKMB_Interface.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Dashboard()
		{
			HttpContext.Session.SetString("Peran", "Berhasil");
			HttpContext.Session.SetString("a", "Berhasil");
			return View();
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