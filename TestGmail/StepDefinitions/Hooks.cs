using BoDi;
using TechTalk.SpecFlow;
using TestGmail.Utilities;
using System.Diagnostics;
using System.Linq;

namespace TestGmail.StepDefinitions
{
    /// <summary>
    /// SpecFlow settings for setup test execution. Provide actions during test execution workflow.
    /// </summary>
    [Binding]
    public class Hooks
    {
        private Driver driver;
        private readonly IObjectContainer objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void Setup()
        {
            this.driver = new Driver();
            this.objectContainer.RegisterInstanceAs<Driver>(this.driver);
        }

        [AfterScenario]
        public void TearDown()
        {
            this.driver.DriverTermination();
        }

        [AfterTestRun]
        public static void AfterTests()
        {
            CloseChromeDriverProcesses();
            //todo: add other browsers post execution actions
        }

        private static void CloseChromeDriverProcesses()
        {
            var chromeDriverProcesses = Process.GetProcesses().
                Where(pr => pr.ProcessName == "chromedriver");

            if (chromeDriverProcesses.Count() == 0)
            {
                return;
            }

            foreach (var process in chromeDriverProcesses)
            {
                process.Kill();
            }
        }
    }
}
