
//Before DIP
//public class FileLogger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"Log to File: {message}");
//    }
//}

//public class OrderService
//{
//    private FileLogger _logger = new FileLogger(); // Direct dependency

//    public void ProcessOrder()
//    {
//        // Business logic...
//        _logger.Log("Order processed.");
//    }
//}
ILogger logger = new FileLogger();
OrderService orderService = new OrderService(logger);

orderService.ProcessOrder();