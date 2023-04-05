using HoyaPH.Repository;
using HoyaPH.Services;
using HoyaPH.ViewModel;
using Refit;

namespace HoyaPH;

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
				fonts.AddFont("GalanoGrotesqueSemiBold.otf", "Semibold");
				fonts.AddFont("GalanoGrotesqueMedium.otf", "Medium");
				fonts.AddFont("GalanoGrotesqueLight.otf", "Light");
			});
        builder.Services.AddTransient<ApiRepository>();

        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<AuthHeader>();
        builder.Services.AddTransient<MainPageViewModel>();

		builder.Services.AddRefitClient<ApiInterface>()
			.ConfigureHttpClient(c => c.BaseAddress = new Uri("https://hoyatserv.loyltwo3ks.com"))
			.AddHttpMessageHandler<AuthHeader>();

		return builder.Build();
	}
}
