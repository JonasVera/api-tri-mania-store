using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.User
{
    public class UserDtoCreate
    {
        [Required (ErrorMessage = "O nome é obrigatorio.")] 
        [StringLength(60,ErrorMessage = "O nome deve ter no máximo {1} caracteres.")]
        public string Name { get; set; }
        [Required (ErrorMessage = "Email é um campo obrigatório.")]
        [EmailAddress (ErrorMessage ="Email em formato inválido.")]
        [StringLength(100,ErrorMessage = "Email deve ter no máximo {1} caracteres.")]  
        public string Email { get; set; }
        [Required (ErrorMessage = "O Cpf é obrigatorio.")] 
        public string Cpf { get; set; }
         public DateTime BirthDate { get; set; }
    }
}
