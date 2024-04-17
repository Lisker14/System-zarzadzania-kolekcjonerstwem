using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace System_zarzadzania_kolekcjonerstwem
{
    public static class Program
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiProgram.CreateMauiAppBuilder();

            builder
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<MainPageViewModel>();
                    services.AddSingleton<EdycjaKolekcjiViewModel>();
                })
                .UseMauiApp<System_zarzadzania_kolekcjonerstwem.App>();

            return builder.Build();
        }
    }
}
