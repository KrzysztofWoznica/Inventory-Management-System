using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFInventoryManagementSystem.UI.ViewModels
{
    public class MenuViewModel : Screen
    {      
       
        private Object _selectedExpander;

        public Object SelectedExpander
        {
            get => _selectedExpander; 
            set
            {
                if (_selectedExpander == value)
                {
                    return;
                }
                _selectedExpander = value;              
                NotifyOfPropertyChange(() => SelectedExpander);
            }
        }


    }
}
