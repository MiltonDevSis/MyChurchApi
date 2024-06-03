using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyChurch.Api.Domain.Services.Interfaces
{

    /// <summary>
    /// Interface genêrica para criação de serviços do tipo CRUD.
    /// </summary>
    /// <typeparam name="RQ">Contrato de request</typeparam>
    /// <typeparam name="RS">Contrato de resonse</typeparam>
    /// <typeparam name="I">Tipo de ID</typeparam>
    public interface IService<RQ, RS, I> where RQ : class
    {
        Task<IEnumerable<RS>> Obter(I idUsuario);

        Task<RS> Obter(I id, I idUsuario);

        Task<RS> Adicionar(RQ entidade, I idUsuario);

        Task<RS> Atualizar(I id, RQ entidade, I idUsuario);

        Task Inativar(I id, I idUsuario);
    }
}