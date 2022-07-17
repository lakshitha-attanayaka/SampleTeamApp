using RestEase.HttpClientFactory;
using SampleTeamApp.RestServices;
using SampleTeamApp.ViewModels;
using SampleTeamApp.Views;

namespace SampleTeamApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UsePrismApp<App>(prism =>
			{
				prism.RegisterTypes(container =>
				{
					container.RegisterForNavigation<HomeView, HomeViewModel>();
				})
				.ConfigureServices(service =>
				{
					service.AddRestEaseClient<IGitHubApiService>("https://api.github.com");
				})
				.OnAppStart(navigationService => navigationService.CreateBuilder().AddNavigationPage().AddSegment<HomeViewModel>().Navigate());
				
			})
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
