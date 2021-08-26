using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace loja_de_games.Models
{
    public class Cliente
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string NomeCli { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string CPFCli { get; set; }

        [RegularExpression("[a-zA-Z0-9_\\.\\+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-\\.]+")]
        public string Email { get; set; }

        [RegularExpression("(^\\+)?[0-9()-]*")]
        public string Celular { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Estado { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Cidade { get; set; }

        [Display(Name = "Logradouro")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Logradouro { get; set; }

        public DateTime DataNascimento
        {
            get
            {
                return this.dataNascimento.HasValue
                ? this.dataNascimento.Value
               : DateTime.Now;
            }
            set
            {
                this.dataNascimento = value;
            }
        }
        private DateTime? dataNascimento = null;
    }

}

