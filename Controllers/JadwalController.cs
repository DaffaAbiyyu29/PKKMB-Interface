using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class JadwalController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
