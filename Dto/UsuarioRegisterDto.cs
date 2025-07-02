using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmprestimosBook.Dto
{
    public class UsuarioRegisterDto
    {

        [Required(ErrorMessage = "Digite a Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite a Sobrenome")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "Digite a Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite a Senha")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Confirma a Senha")]
        public string ConfirmarSenha { get; set; }
        
    }
}