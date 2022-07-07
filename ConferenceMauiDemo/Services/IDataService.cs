using ConferenceMauiDemo.Models;

namespace ConferenceMauiDemo.Services;

public interface IDataService
{
    Task<Session> GetSessionAsync(int id);
    Task<IEnumerable<Session>> GetSessionsAsync();
    Task<Speaker> GetSpeakerAsync(int id);
    Task<IEnumerable<Speaker>> GetSpeakersAsync();
}
