using System;
using System.Collections.Generic;
using System.Text;
using WPFInventoryManagementSystem.Domain.Models.Base;

namespace WPFInventoryManagementSystem.Domain.Models
{
    public class PartCategory : EntityBase
    {       
        public string Name { get; private set; }
        
        private PartCategory()
        {

        }
        public PartCategory(string name)
        {
            Name = name;
        }
    }
}
