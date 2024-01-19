using AutomationUtilities.BrowserUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using UiHelpers.BrowserHelpers;
using UiUtilities.BrowserUtilities;
using UiUtilities.CustomExceptions;

namespace UIPages
{
    public class BaseTestClass
    {
        protected IWebDriver? driver;

        [OneTimeSetUp]
        public void TestSetup()
        {

            var browserType = (BrowserType)Enum.Parse(typeof(BrowserType), "Chrome");

            BrowserFactory browserFactory = browserType switch
            {
                BrowserType.Chrome => new ChromeBrowserFactory(),
                BrowserType.Firefox => new FirefoxBrowserFactory(),
                _ => throw new NotSupportedBrowserTypeException(),

            };
            driver = new BrowserClient(browserFactory).GetBrowser().CreateBrowserInstance();

            Console.WriteLine($"Test Setup - Browser: {driver.GetType().Name}");
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            try
            {
                driver?.Quit();
            }
            finally
            {
                Console.WriteLine($"Driver quit command executed");
            }
            // Close and quit the WebDriver
          

        }

        [TestFixture]
        public class TestClass : BaseTestClass

        {
            [Test]
            public void Test()
            {
                try
                {
                    driver!.Navigate().GoToUrl("https://www.google.com");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
