using CarouselBinding.ViewModels;
using CarouselBinding.Views;
using Microsoft.Extensions.Logging;

namespace CarouselBinding;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .RegisterAppTypes()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }

    public static MauiAppBuilder RegisterAppTypes(this MauiAppBuilder mauiAppBuilder)
    {
        //ViewModels
        mauiAppBuilder.Services.AddTransient<MainPageViewModel>();

        //Views
        mauiAppBuilder.Services.AddTransient<MainPage>();



        return mauiAppBuilder;
    }

}