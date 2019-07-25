using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace TestGmail.Utilities
{
    /// <summary>
    /// Selenium driver wrapper
    /// </summary>
    public class Driver
    {
        public IWebDriver WebDriver;
        public Driver(string browser="Chrome")
        {
            this.InitDriver(browser);
        }

        private void InitDriver(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    this.WebDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
                //todo: add other browsers
                default:
                    throw new KeyNotFoundException("Wrong Browser name. Please choose correct.");
            }

            this.WebDriver.Manage().Window.Maximize();
            this.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void DriverTermination()
        {
            this.WebDriver?.Quit();
        }
    }
}
