using Caliburn.Micro;
using WPFInventoryManagementSystem.UI.Contracts;
using WPFInventoryManagementSystem.UI.Modules.Materials.Inventory.ViewModels;
using WPFInventoryManagementSystem.UI.Modules.Materials.Part.ViewModels;
using WPFInventoryManagementSystem.UI.Modules.Materials.ViewModels;

namespace WPFInventoryManagementSystem.UI.Modules.Materials.Part
{
    public static class MaterialsModuleInstaller
    {
        public static void Install(SimpleContainer container)
        {
            //var childContainer = container.CreateChildContainer();
            //container.AllTypesOf<IMainScreenTabItem>(Assembly.GetExecutingAssembly());

           
            container
                .PerRequest<MaterialsViewModel>()
                .PerRequest<PartMainViewModel>()
                .PerRequest<PartOverviewViewModel>()
                .PerRequest<PartDetailsViewModel>()

                .PerRequest<InventoryMainViewModel>()
                .PerRequest<InventoryItemOverviewViewModel>()

                .PerRequest<IModule, MaterialsModuleImpl>("MaterialsModuleImpl");
        }                
                
        
    }
}

