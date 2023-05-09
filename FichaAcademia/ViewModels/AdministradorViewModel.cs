using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FichaAcademia.ViewModels
{
    public class AdministradorViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        // [EmailAddress(ErrorMessage = "Email inválido")]
        [DataType(DataType.EmailAddress)]
        //public string Email { get; set; }
        public string Email = "maria@hotmail.com";

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Password)]
       // public string Senha { get; set; }
        public string Senha = "abcd";
    }
}

