using WPFInventoryManagementSystem.Domain.Models.Base;

namespace WPFInventoryManagementSystem.Domain.Models
{
    public class UserLocation : EntityBase
    {      
        public User User { get; private set; }
        public Location Location { get; private set; }

        private UserLocation()
        {

        }
        public UserLocation(User user, Location location)
        {
            User = user;
            Location = location;
        }
    }

}
