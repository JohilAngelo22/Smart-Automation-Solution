using TestAutomationFW;
using UiUtilities.BrowserUtilities;

namespace AutomationUtilities.BrowserUtilities
{
    public class FirefoxBrowserFactory : BrowserFactory
    {
        public override IBrowserHandler CreateBrowser()
        {
            return new FirefoxBrowser();
        }
    }

}
