using System;
using WPFInventoryManagementSystem.Domain.Models.Base;

namespace WPFInventoryManagementSystem.Domain.Models
{
    public class InventoryLog : EntityBase
    {      
        public Location BegLocation { get; private set; }
        public Location EndLocation { get; private set; }
        public DateTime Date { get; private set; }
        public InventoryItem InventoryItem { get; private set; }
        public decimal Quantity { get; private set; }


        private InventoryLog()
        {

        }

        public InventoryLog(Location begLocation, Location endLocation, InventoryItem item, decimal qty)
        {
            BegLocation = begLocation;
            EndLocation = endLocation;
            Date = DateTime.UtcNow;
            InventoryItem = item;
            Quantity = qty;
        }
    }

}

