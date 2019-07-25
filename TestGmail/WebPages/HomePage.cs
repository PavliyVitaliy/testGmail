using OpenQA.Selenium;
using TestGmail.Utilities;

namespace TestGmail.WebPages
{
    /// <summary>
    /// Page object encapsulating UI work with main Gmail page.
    /// </summary>
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        public IWebElement TalkRoster => this.driver.FindElement(By.Id("talk_roster"));

        public IWebElement TableEMail => this.driver.FindElement(By.CssSelector(".UI table tbody"));

        public void PageWaitVisible()
        {
            this.TalkRoster.WaitForElementPresent(this.driver);
        }

        public int GetEmailCount()
        {
            return this.TableEMail.FindElements(By.TagName("tr")).Count;
        }
    }
}
