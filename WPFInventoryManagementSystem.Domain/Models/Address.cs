using WPFInventoryManagementSystem.Domain.Models.Base;


namespace WPFInventoryManagementSystem.Domain.Models
{
    public class Address : EntityBase
    {        
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Postcode { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }

        private Address()
        {

        }

        public Address(string street, string city, string state, string postcode, string email, string phone)
        {
            Street = street;
            City = city;
            State = state;
            Postcode = postcode;
            Email = email;
            Phone = phone;
        }

    }
}
