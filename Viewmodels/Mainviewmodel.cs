using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using sucafina.Views;

namespace sucafina.Viewmodels
{
    public partial class Mainviewmodel:ObservableObject
    {

        public Mainviewmodel()
        {
            
        }

        [RelayCommand]
        async Task GotoClients()
        {
            await Shell.Current.GoToAsync(nameof(Clients), false);
        }


        [RelayCommand]
        async Task GotoWarehousing()
        {
            await Shell.Current.GoToAsync(nameof(Warehousing), false);
        }

        [RelayCommand]
        async Task GotoReports()
        {
            await Shell.Current.GoToAsync(nameof(Reports), false);
        }

        [RelayCommand]
        async Task GotoShipments()
        {
            await Shell.Current.GoToAsync(nameof(Shipments), false);
        }
        [RelayCommand]
        async Task GotoDashboard()
        {
            await Shell.Current.GoToAsync(nameof(Dashboard), false);
        }
    }
}
