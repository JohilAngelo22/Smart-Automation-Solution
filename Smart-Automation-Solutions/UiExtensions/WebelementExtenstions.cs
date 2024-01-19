using OpenQA.Selenium;

namespace UiExtensions
{
    public static class WebelementExtenstions
    {
        public static void ClickOnTheElement(this IWebDriver driver, IWebElement element)
        {
            element.Click();
        }

        public static string GetTextFromElement(this IWebDriver driver, IWebElement element)
        {
            return element.Text;
        }

        public static void ClickOnParticularText(this IWebDriver driver, List<IWebElement> elements, string textName)
        {
            foreach(IWebElement webElement in elements)
            {
                if(webElement.Text.Equals(textName))
                {
                    webElement.Click();
                    break;
                }
            }
        }
    }
}
