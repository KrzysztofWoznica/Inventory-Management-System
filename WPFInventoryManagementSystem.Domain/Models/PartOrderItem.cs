
using WPFInventoryManagementSystem.Domain.Models.Base;

namespace WPFInventoryManagementSystem.Domain.Models
{
    public class PartOrderItem : EntityBase
    { 
        public Part Part { get; private set; }   
        public PartOrder Order { get; private set; }
        public decimal Quantity { get; private set; }        
        public decimal UnitCost { get; private set; }
        public string Note { get; private set; }     
        
        private PartOrderItem()
        {

        }

        public PartOrderItem(Part part, PartOrder order, decimal quantity, decimal unitCost, string note)
        {
            //
            if(quantity <= 0)
            {
                Quantity = 1;
            }
            Part = part;
            Order = order;
            Quantity = quantity;
            UnitCost = unitCost;             Note = note;
        }

        public void SetQuantity(int quantity)
        {
            if (quantity <= 0) return;
            Quantity = quantity;                   
        }
        

        public void SetUnitCost(decimal unitCost)
        {
            if (unitCost <= 0) return;
            UnitCost = unitCost;
        }
        
    }
}
