using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ConferenceMauiDemo.Models;

namespace ConferenceMauiDemo.ViewModels
{
    [QueryProperty(nameof(Session), nameof(Session))]
    public class SessionDetailPageViewModel : BaseViewModel
    {

        private Session _session;
        public ICommand OpenTwitterCommand { get; set; }

        public SessionDetailPageViewModel()
        {
            OpenTwitterCommand = new Command(OpenTwitter);
        }

        public Session Session
        {
            get => _session;
            set => SetProperty(ref _session, value);
        }

        private void OpenTwitter()
        {
            Browser.OpenAsync(Session.Speaker.Twitter);
        }
    }
}
