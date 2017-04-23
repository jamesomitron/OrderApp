using Microsoft.AspNetCore.Mvc;

namespace OrderApp.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult NewClient()
        {
            return View();
        }
    }
}