using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class PicPkkmbController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[Route("picpkkmb/update/{pic_npk}")]
		public IActionResult Update(string pic_npk)
		{
			ViewBag.pic_npk = pic_npk;
			return View();
		}

		[Route("picpkkmb/loginpic")]
		public IActionResult LoginPic()
		{
			Response.Cookies.Delete(".AspNetCore.Session");
			ViewBag.role = "Pic";
			return View("LoginPic");
		}

		[Route("picpkkmb/daftarpic")]
		public IActionResult DaftarAkunPic()
		{
			return View("DaftarAkunPic");
		}

		[Route("picpkkmb/resetpasswordpic")]
		public IActionResult LupaPasswordPic()
		{
			return View("LupaPasswordPic");
		}
	}
}
