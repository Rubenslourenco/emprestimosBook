using EmprestimosBook.Dto;
using EmprestimosBook.Models;

namespace EmprestimosBook.Service.LoginService
{
    public interface ILoginInterface
    {
       Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioRegisterDto usuarioRegisterDto);
    }
    
}