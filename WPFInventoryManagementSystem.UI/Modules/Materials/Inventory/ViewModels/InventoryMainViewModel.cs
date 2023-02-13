using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFInventoryManagementSystem.UI.Modules.Materials.Inventory.ViewModels
{
    
    public class InventoryMainViewModel : Conductor<IScreen>.Collection.OneActive
    {
        public InventoryMainViewModel()
        {
            DisplayName = "Inwentarz";
        }
    }
}
