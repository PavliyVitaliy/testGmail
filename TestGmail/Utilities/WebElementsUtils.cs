using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestGmail.Utilities
{
    /// <summary>
    /// Selenium related utility methods
    /// </summary>
    public static class WebElementsUtils
    {
        public static void WaitForElementPresent(this IWebElement element, IWebDriver webDriver)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMinutes(2));
            wait.Until(dr => element.Displayed);
        }

        public static void OpenUrl(Uri url, IWebDriver driver)
        {
            var stringUrl = url.ToString();
            if (driver.Url != stringUrl)
            {
                driver.Navigate().GoToUrl(stringUrl);
            }
        }
    }
}
