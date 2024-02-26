using Microsoft.AspNetCore.Mvc;

namespace WebAppJoesPizza.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
