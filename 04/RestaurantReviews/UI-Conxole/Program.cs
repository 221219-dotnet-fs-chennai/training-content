global using Serilog;
using Data;
namespace UI_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the logger
            Log.Logger = new LoggerConfiguration()
        .WriteTo.File(@"..\..\..\Logs\logs.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true)
        .CreateLogger();

            Log.Logger.Information("----Program starts----");
            UserInteraction.GetRestaurants();
            Log.Logger.Information("----Program Ends----");
        }
    }
}