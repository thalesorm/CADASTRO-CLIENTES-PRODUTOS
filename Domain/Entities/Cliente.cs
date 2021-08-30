using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Cliente: BaseEntity
    {
        public int IdCliente { get; set; }

        public string Name { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }
    }
}
