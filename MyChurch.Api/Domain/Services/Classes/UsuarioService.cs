using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyChurch.Api.Contract.Usuario;
using MyChurch.Api.Domain.Interfaces;
using MyChurch.Api.Domain.Services.Interfaces;

namespace MyChurch.Api.Domain.Services.Classes
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) 
        {
            _usuarioRepository = usuarioRepository;
        }

        public Task<UsuarioResponseContract> Adicionar(UsuarioRequestContract entidade, long idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioResponseContract> Atualizar(long id, UsuarioRequestContract entidade, long idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioLoginResponseContract> Auntenticar(UsuarioLoginRequestContract usuarioLoginRequest)
        {
            throw new NotImplementedException();
        }

        public Task Inativar(long id, long idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsuarioResponseContract>> Obter(long idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioResponseContract> Obter(long id, long idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}