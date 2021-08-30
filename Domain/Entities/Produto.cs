using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Produto: BaseEntity
    {
        public int IdProduto { get; set; }

        public string Name { get; set; }

        public double Valor { get; set; }

        public bool Disponivel { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}
