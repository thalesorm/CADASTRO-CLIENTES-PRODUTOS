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
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _clienteRepository.Delete(id);
        }

        public ClienteViewModel Get(int id)
        {
            var entity = _clienteRepository.Get(id);
            if (entity == null)
                return null;

            return _mapper.Map<ClienteViewModel>(entity);
        }

        public IEnumerable<ClienteViewModel> GetAll()
        {
            var list = _clienteRepository.GetAll();
            if (list == null)
                return new ClienteViewModel[] { };

            return _mapper.Map<IEnumerable<ClienteViewModel>>(list);
        }

        public void Insert(ClienteViewModel viewModel)
        {
            var entity = _mapper.Map<Cliente>(viewModel);

            _clienteRepository.Insert(entity);
        }

        public void Update(ClienteViewModel viewModel)
        {
            var entity = _mapper.Map<Cliente>(viewModel);

            _clienteRepository.Update(entity);
        }
    }
}
