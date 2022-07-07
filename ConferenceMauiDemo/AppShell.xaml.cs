using ConferenceMauiDemo.Views;

namespace ConferenceMauiDemo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(SessionDetailPage), typeof(SessionDetailPage));
	}
}
