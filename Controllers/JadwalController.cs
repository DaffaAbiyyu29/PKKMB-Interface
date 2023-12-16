using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class JadwalController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult TambahJadwal()
		{
			return View();
		}

		[Route("/Jadwal/Ubah/{jdl_idjadwal}")]
		public IActionResult UbahJadwal(string jdl_idjadwal)
		{
			ViewBag.jdl_idjadwal = jdl_idjadwal;
			return View();
		}
	}
}
