using Data.Context;
using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
 
        public ClienteRepository(SqlContext dbContext)
            : base(dbContext)
        {

        }

        public Cliente Get(int id)
        {
            return CurrentSet.Find(id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return CurrentSet.ToList();

        }
    }
}
