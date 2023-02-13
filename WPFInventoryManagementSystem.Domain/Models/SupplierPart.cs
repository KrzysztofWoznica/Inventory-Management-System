using System;
using WPFInventoryManagementSystem.Domain.Models.Base;

namespace WPFInventoryManagementSystem.Domain.Models
{
    public class SupplierPart : EntityBase
    {         
        public Part Part { get; private set; }
        public Supplier Supplier { get; private set; }        
        public decimal MinQuantity { get; private set; }
        public decimal MaxQuantity { get; private set; }
        public decimal? LastCost { get; private set; } 
        public DateTime? LastDate { get; private set; }

        private SupplierPart()
        {
 
        }

        public SupplierPart(Part part, Supplier supplier, decimal minQty, decimal maxQty, decimal? lastCost = null, DateTime? lastDate = null)
        {
            Part = part;
            Supplier = supplier;
            MinQuantity = minQty;
            MaxQuantity = maxQty;
            LastCost = lastCost;
            LastDate = lastDate;
        }

    }
}
