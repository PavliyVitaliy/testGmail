using OpenQA.Selenium;

namespace TestGmail.WebPages
{
    /// <summary>
    /// Base class for all page objects
    /// </summary>
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
           this.driver = driver;
        }
    }
}
