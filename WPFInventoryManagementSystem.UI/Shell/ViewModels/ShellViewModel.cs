using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using WPFInventoryManagementSystem.UI.Contracts;
using WPFInventoryManagementSystem.UI.Modules.Materials.Part.ViewModels;


namespace WPFInventoryManagementSystem.UI.Shell.ViewModels
{
    public class ShellViewModel : Conductor<object>.Collection.OneActive
    {
      
        private ShellMenuItem _selectedMenuItem;   

        public ShellViewModel()
        {
            MenuItems = new ObservableCollection<ShellMenuItem>();                    
        }
                
        public ObservableCollection<ShellMenuItem> MenuItems { get; private set; }

                       

        public ShellMenuItem SelectedMenuItem{
            get => _selectedMenuItem;
            set{
                if (_selectedMenuItem == value)
                    return;
                _selectedMenuItem = value;

                if(value != null)
                    ChangeView(value);

                //
                /*
                if (value != null && value.ScreenViewModel.GetChildren. > 0)
                {
                    SelectedMenuSubItem = _selectedMenuItem.ShellMenuSubItems[0];
                    NotifyOfPropertyChange(() => SelectedMenuSubItem);
                }*/

                NotifyOfPropertyChange(() => SelectedMenuItem);                
            }
        }

        /*
        public ShellMenuItem SelectedMenuItem
        {
            get => _selectedMenuItem;
            set
            {
                if (_selectedMenuItem == value)
                    return;
                _selectedMenuItem = value;

                //
                if (value != null && value.ShellMenuSubItems.Any())
                {
                    SelectedMenuSubItem = _selectedMenuItem.ShellMenuSubItems[0];
                    NotifyOfPropertyChange(() => SelectedMenuSubItem);
                }

                NotifyOfPropertyChange(() => SelectedMenuItem);
            }
        }*/

        

        public void ChangeView(ShellMenuItem selectedMenuItem)
        {   
            Task.Run(async () =>
            {            
                var instance = IoC.GetInstance(selectedMenuItem?.ScreenViewModel.GetType(), null);
                await ActivateItemAsync((IScreen)instance);
            });               

        }
        
               

        /*

        private IScreen _navigationMenu;

        public IScreen NavigationMenu => _navigationMenu ?? (_navigationMenu = new MenuViewModel());*/


        /*
        private INavigationViewModel _navmodel
        public class ShellViewModel(INavigationViewModel navmodel){

            _navmodel = navmodel;   

        }*/


        /*
        private LoginViewModel _loginVm;      

        public ShellViewModel(LoginViewModel loginVm)
        {
            _loginVm = loginVm;            
            ActivateItemAsync(_loginVm);             
        }*/



    }
}
