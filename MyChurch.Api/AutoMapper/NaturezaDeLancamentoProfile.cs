using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyChurch.Api.Contract.NaturezaDeLancamento;
using MyChurch.Api.Domain.Models;

namespace MyChurch.Api.AutoMapper
{
    public class NaturezaDeLancamentoProfile : Profile
    {
        public NaturezaDeLancamentoProfile()
        {
            CreateMap<NaturezaDeLancamento, NaturezaDeLancamentoRequestContract>().ReverseMap();
            CreateMap<NaturezaDeLancamento, NaturezaDeLancamentoResponseContract>().ReverseMap();
        }
    }
}