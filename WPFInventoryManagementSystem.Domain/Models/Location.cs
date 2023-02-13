using System.Collections.Generic;
using WPFInventoryManagementSystem.Domain.Models.Base;

namespace WPFInventoryManagementSystem.Domain.Models
{
    public class Location : EntityBase
    {        
        public Address Address { get; set; } 
        public string Name { get; set; }
        public List<UserLocation> Users { get; set; }

        private Location()
        {

        }
        public Location(Address address, string name)
        {
            Address = address;
            Name = name;
        }

        public Location(string name)
        {
            Name = name;
        }
    
    }
}
