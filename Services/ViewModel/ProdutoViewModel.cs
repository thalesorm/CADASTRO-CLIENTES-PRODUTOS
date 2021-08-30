using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Services.ViewModel
{
    public class ProdutoViewModel
    {
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int IdProduto { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Valor do Produto")]
        [Required(ErrorMessage = "O valor é requerido.")]
        public double Valor { get; set; }

        [Display(Name = "Produto disponível?")]
        public bool Disponivel { get; set; }

        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

        public ClienteViewModel Cliente { get; set; }
    }
}
