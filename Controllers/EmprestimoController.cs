using System.Data;
using ClosedXML.Excel;
using EmprestimosBook.Data;
using EmprestimosBook.Models;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            EmprestimosModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id);

            if (emprestimo == null)
            {
                return NotFound();
            }

            return View(emprestimo);
        }

        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            EmprestimosModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id);

            if (emprestimo == null)
            {
                return NotFound();
            }

            return View(emprestimo);
        }

        public IActionResult Exportar()
        {
            var dados = GetDados();

            using (XLWorkbook workbook = new XLWorkbook())
            {
                workbook.AddWorksheet(dados, "Dados empréstimos");

                using (MemoryStream ms = new MemoryStream())
                {
                    workbook.SaveAs(ms);
                    return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Emprestimos.xls");
                }
            }  
        }

        private DataTable GetDados()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Recebedor", typeof(string));
            dataTable.Columns.Add("Fornecedor", typeof(string));
            dataTable.Columns.Add("Livro", typeof(string));
            dataTable.Columns.Add("Data emprestimo", typeof(DateTime));

            var dados = _db.Emprestimos.ToList();

            if (dados.Count > 0)
            {
                dados.ForEach(emprestimos =>
                {
                    dataTable.Rows.Add(emprestimos.Recebedor, emprestimos.Fornecedor, emprestimos.LivroEmprestado, emprestimos.DataUltimaAtualizacao);
                });
            }
            
            return dataTable;
        }


        [HttpPost]
        public IActionResult Cadastrar(EmprestimosModel emprestimo)
        {
            if (ModelState.IsValid)
            {
                emprestimo.DataUltimaAtualizacao = DateTime.Now;

                _db.Emprestimos.Add(emprestimo);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";

                return RedirectToAction("Index");

            }

            return View();
        }
        [HttpPost]
        public IActionResult Editar(EmprestimosModel emprestimo)
        
        {
            if (ModelState.IsValid)
            {
                var emprestimoDB = _db.Emprestimos.Find(emprestimo.Id);

                emprestimoDB.Recebedor = emprestimo.Recebedor;
                emprestimoDB.Fornecedor = emprestimo.Fornecedor;
                emprestimoDB.LivroEmprestado = emprestimo.LivroEmprestado;   

                _db.Emprestimos.Update(emprestimoDB);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Edição realizado com sucesso!";

                return RedirectToAction("Index");
            }
            
            
            TempData["MensagemSucesso"] = "Algum erro acorreu !";

            return View(emprestimo);
        }

        [HttpPost]
        public IActionResult Excluir(EmprestimosModel emprestimo)
        {

            if (emprestimo == null)
            {
                return NotFound();
            }
            
            _db.Emprestimos.Remove(emprestimo);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Livro excluido com sucesso!";
            
            return RedirectToAction("Index");

         
        }
    }
}