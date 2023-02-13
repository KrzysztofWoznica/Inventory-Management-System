using System;
using System.Collections.Generic;
using System.Text;
using WPFInventoryManagementSystem.Domain.Models.Base;

namespace WPFInventoryManagementSystem.Domain.Models
{
    public class Part : EntityBase
    {
        private List<SupplierPart> _supplierParts = new List<SupplierPart>();
                
        public string Number { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }       
        public PartCategory Category { get; private set; }        
        public Uom Uom { get; private set; }
        public string PictureUri { get; private set; }
        public string LastChangedUser { get; private set; }
        public IEnumerable<SupplierPart> SupplierParts => _supplierParts;
        public DateTime DateCreated { get; private set; } 
        public DateTime DateLastModified { get; private set; } 

        private Part()
        {

        }

        public Part(string number, string name, string description, PartCategory category, Uom uom, 
            string pictureUri, string lastChangedUser)
        {
            Number = number;
            Name = name;
            Description = description;
            Category = category;
            Uom = uom;
            PictureUri = pictureUri;
            LastChangedUser = lastChangedUser;
        }

    }
}
