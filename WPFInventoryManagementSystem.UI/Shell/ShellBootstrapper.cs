using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using WPFInventoryManagementSystem.UI.Contracts;
using WPFInventoryManagementSystem.UI.Helpers;
using WPFInventoryManagementSystem.UI.Shell.ViewModels;
using WPFInventoryManagementSystem.UI.Modules.Materials.Part;

namespace WPFInventoryManagementSystem.UI.Shell
{
    public class ShellBootstrapper : BootstrapperBase
    {
        private SimpleContainer _container = new SimpleContainer();        

        public ShellBootstrapper()
        {
            Initialize();
            
            ConventionManager.AddElementConvention<PasswordBox>(
                PasswordBoxHelper.BoundPasswordProperty,
                "Password",
                "PasswordChanged");
        }
        

        protected override void Configure()
        {                          
            
            ShellInstaller.Install(_container);             

        }
        
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            MaterialsModuleInstaller.Install(_container);
            IoC.Get<IModule>("MaterialsModuleImpl").Init();      


            DisplayRootViewFor<ShellViewModel>();
        }
        
        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        //
        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }

}











