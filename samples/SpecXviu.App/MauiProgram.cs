 global using SpecXviu.App.Services;
global using SpecXviu.App.ViewModels;
global using Refit;
global using System.Collections;
  global using CommunityToolkit.Mvvm.Input;
global using Microsoft.Maui.Dispatching;
global using CommunityToolkit.Maui.Markup;
global using SpecXviu.App;
 using SpecXviu.App.ViewModels.Base;
using CommunityToolkit.Maui;

namespace SpecXviu.App;

public class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder()
								.UseMauiApp<App>()
								.UseMauiCommunityToolkit()
								.UseMauiCommunityToolkitMarkup();

		// Fonts
		builder.ConfigureFonts(fonts => fonts.AddFont("FontAwesome.otf", "FontAwesome"));

		// App Shell
		builder.Services.AddTransient<AppShell>();

		// Services
		builder.Services.AddSingleton<App>();
		builder.Services.AddSingleton(Browser.Default);
		builder.Services.AddSingleton<SettingsService>();
		builder.Services.AddSingleton(Preferences.Default);
 
		// View Models
 		 

		// Pages
		builder.Services.AddTransient<HomePage>();
	 

		return builder.Build();
	}
}