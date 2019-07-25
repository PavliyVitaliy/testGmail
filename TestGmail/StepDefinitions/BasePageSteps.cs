using TechTalk.SpecFlow;
using TestGmail.Utilities;

namespace TestGmail.StepDefinitions
{
    /// <summary>
    /// General steps not related to specific application part. 
    /// </summary>
    [Binding]
    public class BasePageSteps
    {
        private Driver driver;

        public BasePageSteps(Driver driver)
        {
            this.driver = driver;
        }

        [Given(@"I turn on GMAIL")]
        public void GivenGoToGmail()
        {
            WebElementsUtils.OpenUrl(Configuration.Instance.Url, this.driver.WebDriver);
        }
    }
}
