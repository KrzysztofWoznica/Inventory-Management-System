using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPFInventoryManagementSystem.UI.Modules.Materials.Part.Interfaces;

namespace WPFInventoryManagementSystem.UI.Modules.Materials.Part.ViewModels
{
    public class PartMainViewModel : Conductor<IPartScreenTabItem>.Collection.OneActive
    {      

        public PartMainViewModel(PartOverviewViewModel partGeneralInfoViewModel, PartDetailsViewModel partDetailsViewModel)
        {
            DisplayName = "Części";

            Items.Add(partGeneralInfoViewModel);
            Items.Add(partDetailsViewModel);               
            
        }


    }
}
