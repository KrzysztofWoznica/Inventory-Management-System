using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using WPFInventoryManagementSystem.UI.Contracts;
using WPFInventoryManagementSystem.UI.Shell.ViewModels;

namespace WPFInventoryManagementSystem.UI.Shell
{
    public static class ShellInstaller
    {
        public static void Install(SimpleContainer container)
        {
            container.Instance(container);

            container
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<IEventAggregator, EventAggregator>()
                //.PerRequest<ShellViewModel>()
                //.PerRequest<IShell, ShellImpl>()
                .Singleton<ShellViewModel>()
                .Singleton<IShell, ShellImpl>();          
          
        }


    }

    
}
