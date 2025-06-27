using Microsoft.AspNetCore.Mvc;

namespace EmprestimosBook.Controllers
{
 
    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }
    }
}