using Microsoft.AspNetCore.Mvc;

namespace CPS_Batch1_Team2.Controllers
{
    public class AuthController : Controller
    {
        // GET: /Auth/Login
        public IActionResult AuthLogin()
        {
            return View(); // Looks for Views/Auth/Login.cshtml by default.
        }

        // GET: /Auth/Register
        public IActionResult AuthRegister()
        {
            return View(); // Looks for Views/Auth/Register.cshtml.
        }

        // GET: /Auth/ForgotPassword
        public IActionResult AuthForgotPassword()
        {
            return View(); // Looks for Views/Auth/ForgotPassword.cshtml.
        }
    }
}
