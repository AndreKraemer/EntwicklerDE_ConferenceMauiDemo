using ConferenceMauiDemo.ViewModels;

namespace ConferenceMauiDemo.Views;

public partial class SessionsPage : ContentPage
{
    private readonly SessionsPageViewModel _viewModel;

    public SessionsPage(SessionsPageViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = _viewModel = viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.OnAppearing();
    }
}