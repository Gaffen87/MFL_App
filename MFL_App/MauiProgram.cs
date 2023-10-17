using MFL_App.Services;

namespace MFL_App;

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

		builder.Services.AddSingleton<View.RosterPage>();
		
		builder.Services.AddSingleton<ViewModel.RosterViewModel>();
		builder.Services.AddSingleton<Services.RosterService>();

		return builder.Build();
	}
}
