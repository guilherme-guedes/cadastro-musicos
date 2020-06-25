namespace Domain.VOs
{
    public class Address
    {
        public string Country { get;private set;}
        public string State {get; private set;}
        public string City {get; private set;}
        public string Street {get; private set;}

        public Address()
        {

        }

        public Address(string country, string state, string city, string street)
        {
            this.Country = country;
            this.State = state;
            this.City = city;
            this.Street = street;
        }
    }
}