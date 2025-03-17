using Microsoft.AspNetCore.Mvc;

namespace CPS_Batch1_Team2.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
