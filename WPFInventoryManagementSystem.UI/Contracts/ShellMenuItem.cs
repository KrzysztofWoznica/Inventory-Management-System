using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WPFInventoryManagementSystem.UI.Contracts
{
    public class ShellMenuItem
    {

        public string Caption { get; set; }

        public IConductor ScreenViewModel { get; set; }
        
        //public IList<ShellMenuSubItem> ShellMenuSubItems { get; private set; }

        //public ObservableCollection<ShellMenuSubItem> ShellMenuSubItems { get; private set; }

        public ShellMenuItem(string caption, IConductor screenViewModel /*, ObservableCollection<ShellMenuSubItem> items*/)
        {
            ScreenViewModel = screenViewModel;
        


            Caption = caption;   
            
            
        }

    }
}
