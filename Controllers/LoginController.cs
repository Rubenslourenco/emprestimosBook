using EmprestimosBook.Dto;
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


        [HttpPost]
        public IActionResult Registrar(UsuarioRegisterDto usuarioRegisterDto)
        {
            return View(usuarioRegisterDto);
        }
    }
}