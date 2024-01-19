using OpenQA.Selenium;

namespace TestAutomationFW;

public interface IBrowserHandler
{
    IWebDriver CreateBrowserInstance();
}