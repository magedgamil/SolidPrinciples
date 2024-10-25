﻿
//before applying Single Responsibility Principle
//public class NotificationService
//{
//    public void SendNotification(string type, string message)
//    {
//        if (type == "Email")
//        {
//            Console.WriteLine($"Sending Email: {message}");
//            // Email sending logic
//        }
//        else if (type == "SMS")
//        {
//            Console.WriteLine($"Sending SMS: {message}");
//            // SMS sending logic
//        }
//    }
//}
//after applying Single Responsibility Principle

public interface INotification
{
    void Send(string message);
}


