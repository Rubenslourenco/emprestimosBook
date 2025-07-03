using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmprestimosBook.Service.SenhaService
{
    public interface ISenhaInterface
    {
      void CriarSenhaHash(string senha, out byte[] senhaHash, out byte[] senhaSalt);   
    }
}