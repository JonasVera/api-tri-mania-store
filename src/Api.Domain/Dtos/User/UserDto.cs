using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Models;

namespace Api.Domain.Dtos.User
{
    public class UserDto
    {
        
        public Guid Id{ get; set; }
        public string Name { get; set; }
        public string Email { get; set; } 
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; } 
        public ICollection<AddressDto> addresses { get; set; }
    }
}
