using System;

namespace Api.Domain.Models
{
    public class AddressModel
    {
        private Guid _id;
        private string _street;
        private string  _neighborhood;
        private string _city;
        private string _state;
        private DateTime _createAt;
        private DateTime _updateAt;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
 
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public string Neighborhood
        {
            get { return  _neighborhood; }
            set { _neighborhood = value; }
        }
         public string City
        {
            get { return _city; }
            set {_city = value; }
        }
        public string State
        {
            get { return _state; }
            set {_state = value; }
        }


         public DateTime CreateAt
        {
            get { return _createAt; }
            set { _createAt = value == null ? DateTime.UtcNow : value; }
        }

         public DateTime UpdateAt
        {
            get { return _updateAt; }
            set {_updateAt = value; }
        }
    }
}
