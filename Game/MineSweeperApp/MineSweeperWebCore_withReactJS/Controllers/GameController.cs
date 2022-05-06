using Microsoft.AspNetCore.Mvc;

namespace MineSweeperWebCore_withReactJS.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
