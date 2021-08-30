using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface
{
    public interface IClienteRepository
    {
        Cliente Get(int id);
        IEnumerable<Cliente> GetAll();
        void Insert(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(int id);
    }
}
