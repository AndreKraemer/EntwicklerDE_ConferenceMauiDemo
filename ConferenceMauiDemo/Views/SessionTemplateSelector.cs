using ConferenceMauiDemo.Models;
namespace ConferenceMauiDemo.Views;

public class SessionTemplateSelector : DataTemplateSelector
{
    public DataTemplate SessionTemplate { get; set; }
    public DataTemplate KeynoteTemplate { get; set; }
    public DataTemplate BreakTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        switch ((item as Session).SessionType)
        {
            case SessionType.Session:
                return SessionTemplate;
            case SessionType.Keynote:
                return KeynoteTemplate;
            case SessionType.Break:
                return BreakTemplate;
            default:
                return SessionTemplate;

        }

    }
}
