using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTeamApp.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        private INavigationService _navigationService;

        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        [RelayCommand]
        public void UserInfo()
        {
            //navigate to the user
            //_navigationService.CreateBuilder().AddSegment<>().Navigate();
        }
        [RelayCommand]
        public void OrgInfo()
        {
            // navigate to org
            //_navigationService.CreateBuilder().AddSegment<>().Navigate();
        }

    }
}
