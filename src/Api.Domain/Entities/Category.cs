using System;
using System.Collections.Generic;

namespace Api.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Description { get; set; }
        public ICollection<Product> Products { get; set;}
    }
}
