using System;
using System.Collections;

namespace Api.Domain.Models
{
    public class CategoryModel : BaseModel
    { 
        private string _description; 
  
        public string  Description
        {
            get { return _description; }
            set { _description = value; }
        }
   
    }
}
