using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TestAutomationFW;

namespace UiUtilities.BrowserUtilities
{
    public class FirefoxBrowser : IBrowserHandler
    {
        public IWebDriver CreateBrowserInstance()
        {
            return new FirefoxDriver();
        }
    }
}
