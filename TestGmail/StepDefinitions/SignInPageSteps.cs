using System;
using TechTalk.SpecFlow;
using TestGmail.Utilities;
using TestGmail.WebPages;

namespace TestGmail.StepDefinitions
{
    /// <summary>
    /// Sign-in page steps definition.
    /// </summary>
    [Binding]
    public class SignInPageSteps
    {
        private readonly Driver driver;
        private readonly SignInPage signInPage;

        public SignInPageSteps(Driver driver)
        {
            this.driver = driver;
            this.signInPage = new SignInPage(this.driver.WebDriver);
        }

        [When(@"I login using ""(.*)"" credentials")]
        public void WhenILogin(string credential)
        {
            this.WhenIEnterLogin(credential);
            this.WhenIClickButton("EmailNext");
            this.WhenIEnterPassword(credential);
            this.WhenIClickButton("PasswordNext");
        }

        [When(@"I enter ""(.*)"" login into login form")]
        public void WhenIEnterLogin(string login)
        {
            string value;

            switch (login)
            {
                case "valid":
                    value = Configuration.Instance.Email;
                    break;
                case "invalid":
                    value = "invalid email";
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Invalid login parameter. Please choose \"valid\" or \"invalid\".");
            }
            this.signInPage.LoginEmailTxt.SendKeys(value);
        }

        [When(@"I enter ""(.*)"" password into login form")]
        public void WhenIEnterPassword(string password)
        {
            string value;

            switch (password)
            {
                case "valid":
                    value = Configuration.Instance.Password;
                    break;
                case "invalid":
                    value = "invalid email";
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Invalid password parameter. Please choose \"valid\" or \"invalid\".");
            }
            this.signInPage.LoginPasswordTxt.SendKeys(value);
        }

        [When(@"I click ""(.*)"" button in login form")]
        public void WhenIClickButton(string button)
        {
            switch (button)
            {
                case "EmailNext":
                    this.signInPage.EmailNextBtn.Click();
                    break;
                case "PasswordNext":
                    this.signInPage.PasswordNextBtn.Click();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Invalid login parameter. Please choose \"EmailNext\" or \"PasswordNext\".");
            }
        }

    }
}
