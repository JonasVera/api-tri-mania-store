using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Api.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name {get; set;}
        public string Description {get; set;}
        public decimal costValue {get; set;}
        public decimal saleCost {get; set;} 
        public Guid UserID { get; set; }
        [JsonIgnore]
        public User User {get;set;}
        public bool Active {get;set;} 
        public Guid CategoryId { get; set; }
        public  Category Category { get; set; }
       
    }
}
