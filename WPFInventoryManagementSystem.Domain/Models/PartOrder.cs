using System;
using System.Collections.Generic;
using System.Linq;
using WPFInventoryManagementSystem.Domain.Models.Base;

namespace WPFInventoryManagementSystem.Domain.Models
{
    public class PartOrder : EntityBase
    {
        private List<PartOrderItem> _orderItems = new List<PartOrderItem>();          
        public Supplier Supplier { get; private set; }    
        public User Buyer { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime DateConfirmed { get; private set; }
        public DateTime DateShipped { get; private set; }
        public Location ShipTo { get; private set; }
        public string Note { get; private set; }       
        public OrderStatus Status { get; private set; }
        public IEnumerable<PartOrderItem> Orderitems => _orderItems;
        
        private PartOrder()
        {

        }

        public PartOrder(Supplier supplier, User buyer, Location shipTo, string note = "")
        {
            Supplier = supplier;
            Buyer = buyer;
            DateCreated = DateTime.UtcNow;
            Status = OrderStatus.BidRequest;
            ShipTo = shipTo;
            Note = note;
        }

        public void AddOrderItem(Part part, int quantity, decimal unitCost, string note = "")
        {
            var exisitingItem = _orderItems.SingleOrDefault(item => item.Part.Id == part.Id);
            if (exisitingItem != null) {
                exisitingItem.SetQuantity(quantity);
            }
            else
            {
                _orderItems.Add(new PartOrderItem(part, this, quantity, unitCost, note));
            }
        }

        public decimal Total()
        {
            decimal total = 0;
            foreach(var item in _orderItems)
            {
                total += item.Quantity * item.UnitCost;
            }
            return total;
        }

        public void SetStatus(OrderStatus status)
        {
            Status = status;
        }
    }


    public enum OrderStatus
    {
        BidRequest,         
        Pending,
        Shipped      
    }
}












