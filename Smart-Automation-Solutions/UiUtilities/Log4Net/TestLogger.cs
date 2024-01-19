using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;

namespace UiUtilities.Log4Net
{
    public class TestLogger<T>
    {
        public ILog TestLog4Net()
        {
            PatternLayout patternLayout = new()
            {
                ConversionPattern = "%date{ABSOLUTE} - %message  %newline"
            };
            patternLayout.ActivateOptions();

            ConsoleAppender consoleAppender = new()
            {
                Name = "ConsoleAppender",
                Layout = patternLayout,
                Threshold = Level.All
        };
            var fileAppender = new FileAppender()
            {
                Name = "FileAppender",
                Layout = patternLayout,
                Threshold = Level.All,
                AppendToFile = false,
                File = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!.Parent!.Parent!.Parent!.FullName, "Tests\\Logs\\FileLogger.log")
            };

            fileAppender.ActivateOptions();
            consoleAppender.ActivateOptions();
            BasicConfigurator.Configure(consoleAppender);
            return LogManager.GetLogger(typeof(T));
            
        }
    }
}
