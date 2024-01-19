using AutomationUtilities.BrowserUtilities;
using TestAutomationFW;

namespace UiUtilities.BrowserUtilities
{
    public class BrowserClient(BrowserFactory browserFactory)
    {
        private readonly BrowserFactory _browserFactory = browserFactory;

        public IBrowserHandler GetBrowser()
        {
            return _browserFactory.CreateBrowser();
         
        }
    }
}