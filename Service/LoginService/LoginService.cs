using Azure;
using DocumentFormat.OpenXml.ExtendedProperties;
using EmprestimosBook.Data;
using EmprestimosBook.Dto;
using EmprestimosBook.Models;
using EmprestimosBook.Service.LoginService;

namespace EmprestimosBook.Services.LoginService
{
    public class LoginService : ILoginInterface
    {
        private readonly ApplicationDbContext _context;

        public LoginService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioRegisterDto usuarioRegisterDto)
        {
            ResponseModel<UsuarioModel> response = new ResponseModel<UsuarioModel>();
            try
            {
                if (VerificarSeEmailExiste(usuarioRegisterDto))
                {
                    response.Mensagem = "Email de usuario já cadastrado"
                    response.Status = false;
                    return response;
                }
            

            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Status = false;
                return response;
            }
        }

        private bool VerificarSeEmailExiste(UsuarioRegisterDto usuarioRegisterDto)
        {
            var usuario = _context.Usuarios.FirstOrDefault(x => x.Email == usuarioRegisterDto.Email)

            if(usuario == null) {
                return false;
            }

            return true;
        }

    }
}