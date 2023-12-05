using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class MahasiswaBaruController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[Route("mahasiswabaru/update/{mhs_nopendaftaran}")]
		public IActionResult Update(string mhs_nopendaftaran)
		{
			ViewBag.mhs_nopendaftaran = mhs_nopendaftaran;
			return View();
		}

		[Route("mahasiswabaru/loginmahasiswa")]
		public IActionResult LoginMahasiswa()
		{
			Response.Cookies.Delete(".AspNetCore.Session");
			ViewBag.role = "Mahasiswa";
			return View("LoginMahasiswa");
		}

		[Route("mahasiswabaru/daftarmahasiswa")]
		public IActionResult DaftarAkunMahasiswa()
		{
			return View("DaftarAkunMahasiswa");
		}

		[Route("mahasiswabaru/resetpasswordmahasiswa")]
		public IActionResult LupaPasswordMahasiswa()
		{
			return View("LupaPasswordMahasiswa");
		}
	}
}
