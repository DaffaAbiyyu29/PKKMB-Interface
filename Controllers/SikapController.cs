using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class SikapController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
