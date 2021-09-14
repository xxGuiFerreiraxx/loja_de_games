using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loja_de_games.Models
{
    public class Funcionario
    {
        [Display(Name = "Código do funcionário")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string CodigoFunc { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string NomeFunc { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string CPF_Func { get; set; }

        [Display(Name = "RG")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string RgFunc { get; set; }

        public string Email { get; set; }

        [RegularExpression ("(^\\+)?[0-9()-]*")]
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

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Cargo { get; set; }

        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "Data de nascimento obrigatória")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode
= true)]
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
