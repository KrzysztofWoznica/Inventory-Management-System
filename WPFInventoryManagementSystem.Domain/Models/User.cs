using System.Collections.Generic;
using WPFInventoryManagementSystem.Domain.Models.Base;

namespace WPFInventoryManagementSystem.Domain.Models
{
    public class User : EntityBase
    {
        private List<UserLocation> _locations = new List<UserLocation>();    
        public string FirstName { get; private set; }
        public string LastName { get; private set; }      
        public Address Address { get; private set; }
        public string UserName { get; private set; }
        public string UserPassword { get; private set; }
        public IEnumerable<UserLocation> Locations => _locations; 

        private User()
        {

        }

        public User (string firstName, string lastName, string userName, string userPassword)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            UserPassword = userPassword;
        }

        public void SetAddress(Address address)
        {
            if(address != null)
                Address = address;
        }

        public void AssignToLocation(Location location)
        {
            if(location != null)
                _locations.Add(new UserLocation(this, location));
        }

        public void RemoveFromLocation(UserLocation location)
        {
            if (location != null)
                _locations.Remove(location);
        }

      
    }
}
