using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyChurch.Api.Contract.Usuario;
using MyChurch.Api.Domain.Models;

namespace MyChurch.Api.Domain.Services.Interfaces
{
    public interface IUsuarioService : IService<UsuarioRequestContract, UsuarioResponseContract, long>
    {
        Task<UsuarioLoginResponseContract> Auntenticar(UsuarioLoginRequestContract usuarioLoginRequest);
    }
}