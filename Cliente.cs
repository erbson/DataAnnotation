using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Cliente
{
    public class Cliente
    {
        [Required(ErrorMessage ="O email é obrigatorio",AllowEmptyStrings =false)]
        [EmailAddress(ErrorMessage ="O formato desse email não é permitido")]
        public string Email { get; set; }
        [Required(ErrorMessage ="O nome não deve ficar vazio")]
        [MinLength(4,ErrorMessage ="O nome deve ser maior que 4 caracteres.......")]
        [MaxLength(60,ErrorMessage = "o nome não pode ser maior que 60 caracteres ...")]
        public string nome { get; set; }
        [Required(ErrorMessage =" A idade é obrigatoria...")]
        [Range(18,75,ErrorMessage ="A idade deve ser entre 18 a 75 anos ....")]
        public int  idade { get; set; }



    }
}
