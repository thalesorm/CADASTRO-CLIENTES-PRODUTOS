using Data.Context;
using Domain.Entities;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {

        public ProdutoRepository(SqlContext dbContext)
            : base(dbContext)
        {

        }

        public Produto Get(int id)
        {
            return CurrentSet.Include(x => x.Cliente).Where(x => x.IdProduto == id).FirstOrDefault();
        }

        public IEnumerable<Produto> GetAll()
        {
            return CurrentSet.Include(x => x.Cliente).ToList();

        }
    }
}
