

public class DatabaseLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log to Database: {message}");
    }
}