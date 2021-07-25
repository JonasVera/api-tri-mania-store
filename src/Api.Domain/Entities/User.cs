using System;
using System.Collections.Generic;

namespace Api.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name {get; set;}
        public string Cpf {get; set;}
        public string Email {get; set;}
        public DateTime BirthDate {get; set;} 
        public ICollection<Address> Addresses { get; set;} 
        public ICollection<Product> Products { get; set;}
    }
}
