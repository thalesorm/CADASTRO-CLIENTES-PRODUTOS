using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Services.ViewModel
{
    public class ClienteViewModel
    {
        [Key]
        [Display(Name = "Código")]
        public int IdCliente { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "O sobrenome é requerido.")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O email é requerido.")]
        public string Email { get; set; }

        [Display(Name = "Data do Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Ativo")]
        public bool Ative { get; set; }
    }
}
