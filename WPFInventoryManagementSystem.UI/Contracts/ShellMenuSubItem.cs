using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFInventoryManagementSystem.UI.Contracts
{
    public class ShellMenuSubItem
    {
        public string Caption { get; set; }  
        //
        //public object ScreenViewModel { get; set; }
        public IScreen ScreenViewModel { get; set; }


    }
}
