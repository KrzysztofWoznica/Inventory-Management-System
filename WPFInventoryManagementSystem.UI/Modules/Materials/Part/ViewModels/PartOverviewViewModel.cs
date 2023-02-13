using Caliburn.Micro;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using WPFInventoryManagementSystem.UI.Modules.Materials.Part.Interfaces;


namespace WPFInventoryManagementSystem.UI.Modules.Materials.Part.ViewModels
{
    public class PartOverviewViewModel : Screen, IPartScreenTabItem
    {
        public PartOverviewViewModel()
        {            
            DisplayName = "Ogólne";
        }        



    }
}
