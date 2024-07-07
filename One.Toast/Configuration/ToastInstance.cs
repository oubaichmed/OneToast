using Microsoft.AspNetCore.Components;
namespace One.Toast.Configuration;

internal class ToastInstance
{
    public ToastInstance(RenderFragment message, ToastLevel level, ToastSettings toastSettings)
    {
        Message = message;
        Level = level;
        NotificationSettings = toastSettings;
    }
    public ToastInstance(RenderFragment customComponent, ToastSettings settings)
    {
        CustomComponent = customComponent;
        NotificationSettings = settings;
    }

    public Guid Id { get; } = Guid.NewGuid();
    public DateTime TimeStamp { get; } = DateTime.Now;
    public RenderFragment? Message { get; set; }
    public ToastLevel Level { get; }
    public ToastSettings NotificationSettings { get; }
    public RenderFragment? CustomComponent { get; }
}
