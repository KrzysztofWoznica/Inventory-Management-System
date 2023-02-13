using System;
using System.Collections.Generic;
using System.Text;
using WPFInventoryManagementSystem.Domain.Models.Base;

namespace WPFInventoryManagementSystem.Domain.Models
{
    public class Supplier : EntityBase
    {
        private List<SupplierPart> _supplierParts = new List<SupplierPart>();       
        public string Name { get; private set; }   
        public decimal MinOrderAmount { get; private set; }
        public string WebsiteUrl { get; private set; } 
        public Address Address { get; private set; }
        public IEnumerable<SupplierPart> SupplierParts => _supplierParts;

        private Supplier()
        {

        }

        public Supplier(string name, decimal minOrderAmount = 0, string websiteUrl = "")
        {
            Name = name;
            MinOrderAmount = minOrderAmount;
            WebsiteUrl = websiteUrl;
        }

        public void SetAddress(Address address)
        {
            if (address != null)
                Address = address;
        }


    }
}
