using Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interface
{
    public interface IProdutoService
    {
        ProdutoViewModel Get(int id);
        IEnumerable<ProdutoViewModel> GetAll();
        void Insert(ProdutoViewModel viewModel);
        void Update(ProdutoViewModel viewModel);
        void Delete(int id);
    }
}
