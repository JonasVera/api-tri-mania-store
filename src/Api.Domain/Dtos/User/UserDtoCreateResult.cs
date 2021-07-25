using System;
using System.Collections.Generic;
using Api.Domain.Entities;

namespace Api.Domain.Dtos.User
{
    public class UserDtoCreateResult
    {
        public Guid Id { get; set; }    
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public ICollection<Address> addresses { get; set; }

    }
}
