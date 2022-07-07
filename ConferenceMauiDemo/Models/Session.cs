namespace ConferenceMauiDemo.Models;

public class Session
{
    public int Id { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }

    public SessionType SessionType { get; set; }

    public Speaker Speaker { get; set; }
    public int SpeakerId { get; set; }

    public string Time { get; set; }

}
