using System;
using System.Collections;
using Api.Domain.Entities;

namespace Api.Domain.Models
{
    public class ProductModel : BaseModel
    {
      
        private string _name;  

         private string _description;

        private decimal _costValue { get; set; } 
        public decimal _saleCost { get; set; } 

        public Category _category { get; set; } 

        public User _user { get; set; }

        private bool _active { get; set; } 
        private string  Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string  Description
        {
            get { return _description; }
            set { _description = value; }
        }
         private decimal CostValue
        {
            get { return _costValue; }
            set { _costValue = value; }
        }
        private decimal SaleCost
        {
            get { return _saleCost; }
            set { _saleCost = value; }
        }
    
        private Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
      private User User
        {
            get { return _user; }
            set { _user = value; }
        }
    }
}
