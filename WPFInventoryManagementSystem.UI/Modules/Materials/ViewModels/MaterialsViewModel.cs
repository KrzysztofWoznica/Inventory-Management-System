using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using WPFInventoryManagementSystem.UI.Modules.Materials.Inventory.ViewModels;
using WPFInventoryManagementSystem.UI.Modules.Materials.Part.ViewModels;

namespace WPFInventoryManagementSystem.UI.Modules.Materials.ViewModels
{
    public class MaterialsViewModel : Conductor<IScreen>.Collection.OneActive
    {
        
        public MaterialsViewModel(PartMainViewModel partMainViewModel, InventoryMainViewModel inventoryMainViewModel)
        {
            DisplayName = "Materiały";

            Items.Add(partMainViewModel);
            Items.Add(inventoryMainViewModel);

            

            //ActivateItemAsync(partMainViewModel);
        }


    }
}
