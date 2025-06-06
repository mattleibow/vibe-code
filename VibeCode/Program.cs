using Microsoft.Extensions.Logging;

namespace VibeCode;

public class Program
{
    public static void Main(string[] args)
    {
        using var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
            builder.SetMinimumLevel(LogLevel.Debug);
        });

        var logger = loggerFactory.CreateLogger<Program>();
        
        logger.LogInformation("VibeCode application starting...");
        
        Console.WriteLine("Hello, VibeCode!");
        Console.WriteLine("This is a .NET application ready to be enhanced with MAUI!");
        
        logger.LogInformation("VibeCode application completed.");
    }
}