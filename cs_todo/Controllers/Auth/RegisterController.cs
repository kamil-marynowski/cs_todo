using Microsoft.AspNetCore.Mvc;

namespace cs_todo.Controllers.Auth
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
