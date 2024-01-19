using TestAutomationFW;
using UiUtilities.BrowserUtilities;

namespace AutomationUtilities.BrowserUtilities
{
    public class ChromeBrowserFactory : BrowserFactory
    {
        public override IBrowserHandler CreateBrowser()
        {
            return new ChromeBrowser();
        }
    }
}
