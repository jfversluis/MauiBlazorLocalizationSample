using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiBlazorLocalizationSample.Data;

namespace MauiBlazorLocalizationSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.RegisterBlazorMauiWebView()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		builder.Services.AddSingleton<WeatherForecastService>();

		builder.Services.AddSingleton<IDialogService, DialogService>();

		builder.Services.AddLocalization();

		return builder.Build();
	}
}
