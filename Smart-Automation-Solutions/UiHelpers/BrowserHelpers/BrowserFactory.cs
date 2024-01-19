using TestAutomationFW;

namespace AutomationUtilities.BrowserUtilities
{
    public abstract class BrowserFactory
    {
        public abstract IBrowserHandler CreateBrowser();
    }
}