using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmprestimoLivros.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Digite o nome do Recebedor!")]
        public string Recebedor { get; set; }


        [Required(ErrorMessage = "Digite o nome do Fornecedor!")]
        public string Fornecedor { get; set; }


        [Required(ErrorMessage = "Digite o nome do Livro!")]
        public string LivroEmprestado { get; set; }


        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now; //no regitro, será sempre o horário atual do sistema
    }
}