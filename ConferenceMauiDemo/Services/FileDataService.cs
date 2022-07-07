using ConferenceMauiDemo.Models;
using System.Text.Json;

namespace ConferenceMauiDemo.Services;

public class FileDataService : IDataService
{

    private IList<Speaker> _speakers;
    private IList<Session> _sessions;

    private JsonSerializerOptions _serializeOptions = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    };

    public async Task<Session> GetSessionAsync(int id)
    {

        return (await GetSessionsAsync())?.FirstOrDefault(x => x.Id == id);
    }

    public async Task<IEnumerable<Session>> GetSessionsAsync()
    {
        if (_sessions == null || !_sessions.Any())
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("sessions.json");
            _sessions = JsonSerializer.Deserialize<List<Session>>(stream, _serializeOptions);
            foreach (var session in _sessions.Where(x => x.SessionType != SessionType.Break))
            {
                session.Speaker = await GetSpeakerAsync(session.SpeakerId);
            }
        }
        return _sessions;
    }

    public async Task<Speaker> GetSpeakerAsync(int id)
    {
        return (await GetSpeakersAsync())?.FirstOrDefault(x => x.Id == id);
    }

    public async Task<IEnumerable<Speaker>> GetSpeakersAsync()
    {
        if (_speakers == null || !_speakers.Any())
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("speakers.json");
            _speakers = JsonSerializer.Deserialize<List<Speaker>>(stream, _serializeOptions);

        }
        return _speakers;
    }
}
