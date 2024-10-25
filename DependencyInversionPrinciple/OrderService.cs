
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
public class OrderService
{
    private readonly ILogger _logger;

    // Inject the logger via constructor
    public OrderService(ILogger logger)
    {
        _logger = logger;
    }

    public void ProcessOrder()
    {
        // Business logic...
        _logger.Log("Order processed.");
    }
}
