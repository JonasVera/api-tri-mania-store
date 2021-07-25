using System;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;

namespace Api.Domain.Dtos.Product
{
    public class ProductDto
    {
        public string Name {get; set;}
        public string Description {get; set;}
        public decimal CostValue {get; set;}
        public decimal SaleCost {get; set;} 
        public Guid CategoryID {get; set;} 
        public Guid UserID {get; set;} 
        public bool active {get;set;}
    }
}
