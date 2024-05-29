using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyChurch.Api.Domain.Models;

namespace MyChurch.Api.Domain.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario, long>
    {
        Task<Usuario?> Obter(string  email);
    }
}