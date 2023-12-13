using Microsoft.AspNetCore.Mvc;

namespace DockerBank.Controllers
{
	public class BankController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}

		public IActionResult Dashboard()
		{
			return View();
		}

		// Add a Logout action if needed
		[HttpPost]
		public IActionResult Logout()
		{
			// Perform logout logic here
			return RedirectToAction("Login");
		}
	}
}
