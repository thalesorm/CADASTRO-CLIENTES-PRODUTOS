using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface
{
    public interface IProdutoRepository
    {
        Produto Get(int id);
        IEnumerable<Produto> GetAll();
        void Insert(Produto produto);
        void Update(Produto produto);
        void Delete(int id);
    }
}
