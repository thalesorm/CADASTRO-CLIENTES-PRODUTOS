using AutoMapper;
using Domain.Entities;
using Domain.Interface;
using Services.Interface;
using Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _ProdutoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository ProdutoRepository, IMapper mapper)
        {
            _ProdutoRepository = ProdutoRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _ProdutoRepository.Delete(id);
        }

        public ProdutoViewModel Get(int id)
        {
            var entity = _ProdutoRepository.Get(id);
            if (entity == null)
                return null;

            return _mapper.Map<ProdutoViewModel>(entity);
        }

        public IEnumerable<ProdutoViewModel> GetAll()
        {
            var list = _ProdutoRepository.GetAll();
            if (list == null)
                return new ProdutoViewModel[] { };

            return _mapper.Map<IEnumerable<ProdutoViewModel>>(list);
        }

        public void Insert(ProdutoViewModel viewModel)
        {
            
                var entity = _mapper.Map<Produto>(viewModel);

                _ProdutoRepository.Insert(entity);        

        }

        public void Update(ProdutoViewModel viewModel)
        {
            var entity = _mapper.Map<Produto>(viewModel);

            _ProdutoRepository.Update(entity);
        }
    }
}