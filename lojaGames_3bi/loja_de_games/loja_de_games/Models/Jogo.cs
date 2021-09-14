using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loja_de_games.Models
{
    public class Jogo
    {
        [Display(Name = "Código do jogo")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string CodigoJogo { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string NomeJogo { get; set; }

        [Display(Name = "Versão")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Versao { get; set; }

        [Display(Name = "Desenvolvedor do jogo")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Desenvolvedor { get; set; }

        [Display(Name = "Gênero do jogo")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Genero { get; set; }

        [Display(Name = "Faixa etária")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string FaixaEtaria { get; set; }

        [Display(Name = "Plataforma do jogo")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Plataforma { get; set; }

        [Display(Name = "Sinopse do jogo")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string Sinopse { get; set; }

        [Display(Name = "Ano de lançamento")]
        [Required(ErrorMessage = "preenchimento do campo obrigatório")]
        public string AnoLancamento { get; set; }
    }
}