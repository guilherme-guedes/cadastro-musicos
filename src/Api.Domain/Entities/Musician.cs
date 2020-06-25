using Domain.VOs;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Musician : BaseEntity
    {
        public string Name { get; private set;}
        public string Email {get; private set;}
        public string Phone { get; private set;}
        public IList<Genre> Genres {get; private set;}
        public Address Address {get; private set;}

        public Musician(){}
        
        public Musician(string name, string email, string phone, IList<Genre> genres, Address address)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Genres = genres;
            this.Address = address;
        }
    }
}