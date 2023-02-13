

using WPFInventoryManagementSystem.Domain.Models.Base;

namespace WPFInventoryManagementSystem.Domain.Models
{
    public class InventoryItem : EntityBase
    {              
        public Part Part { get; private set; }
        public decimal Quantity { get; private set; } 
        public Location Location { get; private set; }

        private InventoryItem()
        {

        }
        public InventoryItem(Part part, decimal qty, Location location)
        {
            Part = part;
            Quantity = qty;
            Location = location;
        }
       
   
    }
}

