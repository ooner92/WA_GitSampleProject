using Microsoft.AspNetCore.Mvc;

namespace WA_GitSampleProject.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			Random rdn = new();

			return View(rdn.Next());
		}
	}
}
