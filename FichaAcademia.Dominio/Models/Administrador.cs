using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FichaAcademia.Dominio.Models
{
    public class Administrador
    {
        public int AdministradorId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, ErrorMessage = "Use menos caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        //[RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        [DataType(DataType.EmailAddress)]
        //public string Email { get; set; }
        public string Email = "maria@hotmail.com";


        [Required(ErrorMessage = "Campo obrigatório")]
        //[StringLength(10, MinimumLength = 4, ErrorMessage = "Informe uma senha de 4 a 10 caracteres")]
        [DataType(DataType.Password)]
        // public string Senha { get; set; }
        public string Senha = "abcd";
    }
}

