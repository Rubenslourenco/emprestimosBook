using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EmprestimosBook.Data;
using EmprestimosBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmprestimosBook.Controllers
{
   
    public class EmprestimoController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmprestimoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _db.Emprestimos;
            return View(emprestimos);
        }

       
    }
}