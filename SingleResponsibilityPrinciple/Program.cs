
public class Program
{
    private static void Main(string[] args)
    {
        // Use Email notification
        INotification emailNotification = new EmailNotification();
        var emailService = new NotificationService(emailNotification);
        emailService.SendNotification("Hello via Email!");

        // Use SMS notification
        INotification smsNotification = new SMSNotification();
        var smsService = new NotificationService(smsNotification);
        smsService.SendNotification("Hello via SMS!");
    }
}
