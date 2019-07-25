using NUnit.Framework;
using TechTalk.SpecFlow;
using TestGmail.Utilities;
using TestGmail.WebPages;

namespace TestGmail.StepDefinitions
{
    /// <summary>
    /// Steps definition related to Gmail home page
    /// </summary>
    [Binding]
    public class HomePageSteps
    {
        private readonly Driver driver;
        private readonly HomePage homePage;

        public HomePageSteps(Driver driver)
        {
            this.driver = driver;
            this.homePage = new HomePage(this.driver.WebDriver);
        }

        [Then(@"I am on the gmail home page")]
        public void ThenIOnHomePage()
        {
            this.homePage.PageWaitVisible();
            Assert.IsTrue(this.homePage.TalkRoster.Displayed);
        }

        [Then(@"I see more Emails then (.*) on the gmail home page")]
        public void ThanISeeCountEMailOnHomePage(int countEmail)
        {
            Assert.Greater(this.homePage.GetEmailCount(), countEmail, "Invalid number of emails per page.");
        }
    }
}
