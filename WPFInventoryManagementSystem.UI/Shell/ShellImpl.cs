using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using WPFInventoryManagementSystem.UI.Contracts;
using WPFInventoryManagementSystem.UI.Shell.ViewModels;

namespace WPFInventoryManagementSystem.UI.Shell
{
    public class ShellImpl : IShell
    {       
        private readonly ShellViewModel _shellViewModel;

        public ShellImpl(ShellViewModel shellViewModel)
        {            
            _shellViewModel = shellViewModel;
        }

        public IList<ShellMenuItem> MenuItems => _shellViewModel.MenuItems;

        
      
    }
}
