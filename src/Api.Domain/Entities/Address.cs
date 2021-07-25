using System;
using System.Text.Json.Serialization;

namespace Api.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string Street { get; set; }
        public string neighborhood { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public Guid UserID { get; set; }
        [JsonIgnore]
        public  User user {get;set;}
}
}
