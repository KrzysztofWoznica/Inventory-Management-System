using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using WPFInventoryManagementSystem.UI.Shell;

namespace WPFInventoryManagementSystem.UI.Contracts
{
    public interface IShell
    {
        IList<ShellMenuItem> MenuItems { get; }
        
    }
}
