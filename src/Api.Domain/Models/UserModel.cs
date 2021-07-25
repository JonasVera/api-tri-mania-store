using System;
using System.Collections;

namespace Api.Domain.Models
{
    public class UserModel
    {
        private Guid _id;
        private string _name;
        private string _cpf;
        private DateTime _birthDate;
        private DateTime _updateAt;
        private DateTime _createAt;

        private ICollection _adresses;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
         public DateTime BirthDate
        {
            get { return _birthDate; }
            set {_birthDate = value; }
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
     public ICollection Adreesses
        {
            get { return _adresses; }
            set {_adresses = value; }
        } 
    }
}
