public interface INotificationSender {
    void Send(string message);
}

public class EmailSender : INotificationSender {
    public void Send(string message) {
        Console.WriteLine("Email sent: " + message);
    }
}

public class SmsSender : INotificationSender {
    public void Send(string message) {
        Console.WriteLine("SMS sent: " + message);
    }
}

public class NotificationService {
    private readonly List<INotificationSender> senders;

    public NotificationService(List<INotificationSender> senders) {
        this.senders = senders;
    }

    public void SendNotification(string message) {
        foreach (var sender in senders) {
            sender.Send(message);
        }
    }
}
