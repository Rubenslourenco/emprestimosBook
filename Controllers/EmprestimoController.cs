using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmprestimosBook.Controllers
{
    [Route("[controller]")]
    public class EmprestimoController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

       
    }
}