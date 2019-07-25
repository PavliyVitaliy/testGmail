using OpenQA.Selenium;

namespace TestGmail.WebPages
{
    /// <summary>
    /// Page object encapsulating UI work with login page.
    /// </summary>
    public class SignInPage : BasePage
    {
        public SignInPage(IWebDriver driver) : base(driver) { }

        public IWebElement LoginEmailTxt => this.driver.FindElement(By.Id("identifierId"));
        public IWebElement LoginPasswordTxt => this.driver.FindElement(By.Name("password"));
        public IWebElement EmailNextBtn => this.driver.FindElement(By.Id("identifierNext"));
        public IWebElement PasswordNextBtn => this.driver.FindElement(By.Id("passwordNext"));
    }
}
