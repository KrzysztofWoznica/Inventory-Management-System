using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPFInventoryManagementSystem.UI.Contracts;
using WPFInventoryManagementSystem.UI.Modules.Materials.Part.ViewModels;
using WPFInventoryManagementSystem.UI.Modules.Materials.ViewModels;

namespace WPFInventoryManagementSystem.UI.Modules.Materials.Part
{
    public class MaterialsModuleImpl : IModule
    {
        private readonly IShell _shell;
        //private readonly PartMainViewModel _materialsMainViewModel;
        private readonly MaterialsViewModel _materialsViewModel;



        public MaterialsModuleImpl(IShell shell, MaterialsViewModel materialsViewModel)
        {
            _shell = shell;
            _materialsViewModel = materialsViewModel;            
        }

        public void Init()
        {
            _shell.MenuItems.Add(new ShellMenuItem("Materiały", _materialsViewModel));
        }

       
    }
}
