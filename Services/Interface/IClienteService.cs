using Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interface
{
    public interface IClienteService
    {
        ClienteViewModel Get(int id);
        IEnumerable<ClienteViewModel> GetAll();
        void Insert(ClienteViewModel viewModel);
        void Update(ClienteViewModel viewModel);
        void Delete(int id);
    }
}
