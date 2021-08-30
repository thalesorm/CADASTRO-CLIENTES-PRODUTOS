using AutoMapper;
using Domain.Entities;
using Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.AutoMapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<Produto, ProdutoViewModel>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}
