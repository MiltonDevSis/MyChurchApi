using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyChurch.Api.Contract.Usuario
{
    public class UsuarioResponseContract : UsuarioRequestContract
    {
        public long Id { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}