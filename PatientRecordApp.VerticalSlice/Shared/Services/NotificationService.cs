using PatientRecordApp.VerticalSlice.Shared.Interfaces;

namespace PatientRecordApp.VerticalSlice.Shared.Services;

public class NotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Notification sent: {message}");
    }
}