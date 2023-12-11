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

		[Route("panitiakesekretariatan/informasikelompok")]
		public IActionResult InformasiKelompok()
		{
			return View();
		}

		[Route("panitiakesekretariatan/informasiruangan")]
		public IActionResult InformasiRuangan()
		{
			return View();
		}

		[Route("panitiakesekretariatan/informasitambahruangan")]
		public IActionResult InformasiTambahRuangan()
		{
			return View();
		}

		[Route("panitiakesekretariatan/informasiubahruangan")]
		public IActionResult InformasiUbahRuangan()
		{
			return View();
		}

		[Route("panitiakesekretariatan/informasitugas")]
		public IActionResult InformasiTugas()
		{
			return View();
		}

		[Route("panitiakesekretariatan/nilaitugas")]
		public IActionResult NilaiTugas()
		{
			return View();
		}

		[Route("panitiakesekretariatan/nilaisikap")]
		public IActionResult NilaiSikap()
		{
			return View();
		}

		[Route("panitiakesekretariatan/tambahnilaisikap")]
		public IActionResult TambahNilaiSikap()
		{
			return View();
		}

		[Route("panitiakesekretariatan/ubahnilaisikap")]
		public IActionResult UbahNilaiSikap()
		{
			return View();
		}

		[Route("panitiakesekretariatan/nilaijamplus")]
		public IActionResult NilaiJamPlus()
		{
			return View();
		}

		[Route("panitiakesekretariatan/nilaijamminus")]
		public IActionResult NilaiJamMinus()
		{
			return View();
		}

		[Route("panitiakesekretariatan/nilaiabsensi")]
		public IActionResult NilaiAbsensi()
		{
			return View();
		}

		[Route("panitiakesekretariatan/evaluasi")]
		public IActionResult Evaluasi()
		{
			return View();
		}

		[Route("panitiakesekretariatan/kelulusan")]
		public IActionResult Kelulusan()
		{
			return View();
		}
	}
}
