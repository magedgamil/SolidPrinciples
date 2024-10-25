
public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log to File: {message}");
    }
}
