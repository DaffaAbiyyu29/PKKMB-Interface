using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class PanitiaKesekretariatanController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[Route("panitiakesekretariatan/update/{ksk_nim}")]
		public IActionResult Update(string ksk_nim)
		{
			ViewBag.ksk_nim = ksk_nim;
			return View();
		}

		[Route("panitiakesekretariatan/loginksk")]
		public IActionResult LoginKsk()
		{
			Response.Cookies.Delete(".AspNetCore.Session");
			ViewBag.role = "ksk";
			return View();
		}

		[Route("panitiakesekretariatan/daftarksk")]
		public IActionResult DaftarAkunKsk()
		{
			return View();
		}

		[Route("panitiakesekretariatan/resetpasswordksk")]
		public IActionResult LupaPasswordKsk()
		{
			return View();
		}

		[Route("panitiakesekretariatan/informasimahasiswa")]
        public IActionResult InformasiMahasiswa()
        {
            return View();
        }

        [Route("panitiakesekretariatan/informasijadwal")]
        public IActionResult InformasiJadwal()
        {
            return View();
        }
    }
}
