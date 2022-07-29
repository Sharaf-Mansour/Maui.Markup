global using CommunityToolkit.Maui.Markup.Sample.Pages;
global using CommunityToolkit.Maui.Markup.Sample.Services;
global using CommunityToolkit.Maui.Markup.Sample.ViewModels;
global using Refit;
global using System.Collections;
global using CommunityToolkit.Maui.Markup.Sample.Models;
global using CommunityToolkit.Maui.Markup.Sample.Pages.Base;
global using CommunityToolkit.Maui.Markup.Sample.Views.News;
global using CommunityToolkit.Mvvm.Input;
global using Microsoft.Maui.Dispatching;
global using CommunityToolkit.Maui.Markup;
global using CommunityToolkit.Maui.Markup.Sample;
global using HelloMotherFuckers;
using CommunityToolkit.Maui.Markup.Sample.ViewModels.Base;

namespace CommunityToolkit.Maui.Markup.Sample;

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