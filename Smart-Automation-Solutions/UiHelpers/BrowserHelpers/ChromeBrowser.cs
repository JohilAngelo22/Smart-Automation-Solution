using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestAutomationFW;

namespace UiUtilities.BrowserUtilities
{
    public class ChromeBrowser : IBrowserHandler
    {
        public IWebDriver CreateBrowserInstance()
        {
            return new ChromeDriver();
        }
    }
}
