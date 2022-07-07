using ConferenceMauiDemo.Services;
using ConferenceMauiDemo.Views;
using System.Collections.ObjectModel;
using ConferenceMauiDemo.Models;
using System.Windows.Input;


namespace ConferenceMauiDemo.ViewModels;

public class SessionsPageViewModel : BaseViewModel
{
    private readonly IDataService _dataService;

    private readonly ObservableCollection<Session> _sessions = new ObservableCollection<Session>();

    public SessionsPageViewModel(IDataService dataService)
    {
        _dataService = dataService;
        NavigateToDetailsCommand = new Command<Session>(NavigateToDetailsPage);
    }

    private void NavigateToDetailsPage(Session session)
    {
        var navigationParameter = new Dictionary<string, object>
            {
                { "Session", session }
            };
        Shell.Current.GoToAsync($"{nameof(SessionDetailPage)}", navigationParameter);
    }

    public ObservableCollection<Session> Sessions => _sessions;

    public ICommand NavigateToDetailsCommand { get; set; }

    public async Task OnAppearing()
    {
        _sessions.Clear();
        var sessions = await _dataService.GetSessionsAsync();
        foreach (var session in sessions)
        {
            _sessions.Add(session);
        }
    }

}
