using sucafina.Views;

namespace sucafina
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            Routing.RegisterRoute(nameof(Clients), typeof(Clients));
            Routing.RegisterRoute(nameof(Dashboard), typeof(Dashboard));
            Routing.RegisterRoute(nameof(Reports), typeof(Reports));
            Routing.RegisterRoute(nameof(Shipments), typeof(Shipments));
            Routing.RegisterRoute(nameof(Warehousing), typeof(Warehousing));
        }
    }
}
