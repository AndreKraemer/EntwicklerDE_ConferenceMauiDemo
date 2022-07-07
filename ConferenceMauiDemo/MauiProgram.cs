using ConferenceMauiDemo.Services;
using ConferenceMauiDemo.ViewModels;
using ConferenceMauiDemo.Views;


namespace ConferenceMauiDemo;

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
			})
			;

        builder.Services.AddTransient<SessionsPage>();
        builder.Services.AddTransient<SessionsPageViewModel>();


        builder.Services.AddTransient<SessionDetailPage>();
        builder.Services.AddTransient<SessionDetailPageViewModel>();

        builder.Services.AddTransient<IDataService, FileDataService>();

        return builder.Build();
	}
}
