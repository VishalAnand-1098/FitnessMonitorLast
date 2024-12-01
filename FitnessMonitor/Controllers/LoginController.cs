using FitnessMonitor.Data;
using FitnessMonitor.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;


namespace FitnessMonitor.Controllers
{
    public class LoginController : Controller
    {
        private readonly FitnessTrackerDbContext _context;
        

        public LoginController(FitnessTrackerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users
                    .FirstOrDefault(u => u.Name == model.Name && u.Password == model.Password);

                if (user != null)
                {
                    TempData["UserName"] = model.Name; // Set this to the logged-in user's name

                    // Redirect to home or dashboard
                    return RedirectToAction("index", "DashBoard");
                }

                ViewBag.Error = "Invalid login attempt.";
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");

            }
            return View(model);
        }

    }
}
