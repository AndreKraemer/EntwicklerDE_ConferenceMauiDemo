namespace ConferenceMauiDemo;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnLocationClicked(object sender, EventArgs e)
	{
		var placemark = new Placemark
		{
			CountryName = "Germany",
			Thoroughfare = "Rheinstr. 66",
			Locality = "Mainz",
			PostalCode = "55116"
		};

		var options = new MapLaunchOptions { Name = "BASTA Mainz" };


		await Map.OpenAsync(placemark, options);
	}
}

