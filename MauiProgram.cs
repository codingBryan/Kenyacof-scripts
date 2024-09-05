using Microsoft.Extensions.Logging;
using sucafina.Viewmodels;
using sucafina.Views;

namespace sucafina
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<Mainviewmodel>();
            builder.Services.AddSingleton<Dashboard>();
            builder.Services.AddSingleton<Clients>();
            builder.Services.AddSingleton<Reports>();
            builder.Services.AddSingleton<Shipments>();
            builder.Services.AddSingleton<Warehousing>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
