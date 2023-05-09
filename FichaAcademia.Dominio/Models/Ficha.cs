using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FichaAcademia.Dominio.Models
{
    public class Ficha
    {
        public int FichaId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        [Remote("FichaExiste", "Fichas", AdditionalFields = "FichaId")]
        public string Nome { get; set; }


        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Cadastro { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Validade { get; set; }

        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public ICollection<ListaExercicio> ListaExercicios { get; set; }
    }
}

