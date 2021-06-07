using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumShowcaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = GetDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5); //Tells WebDriver to send requests to DOM for a certain amount of time when trying to find an element or elements if they are not immediately available
            driver.Navigate().GoToUrl("http://testingchallenges.thetestingmap.org/challenge8.php"); //Opens the requested url

            driver.FindElement(By.Name("selling")).SendKeys("QA Services");
            driver.FindElement(By.Name("description")).SendKeys("Automation");

            IWebElement startTimeInput = driver.FindElement(By.Name("start_date"));
            startTimeInput.Clear();
            startTimeInput.SendKeys("12:30");
            IWebElement endTimeInput = driver.FindElement(By.Name("end_date"));
            endTimeInput.Clear();
            endTimeInput.SendKeys("12:50");

            driver.FindElement(By.Name("formSubmit")).Click();

            //explicit waits
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(x=> x.FindElement(By.XPath("//table")).Displayed);
            wait.Until(x => x.FindElement(By.XPath("//h1")).Text == "Testing Challenge #8 - State Transition");
            driver.Quit();
        }

        /// <summary>
        /// Initializes new instance of ChromeDriver
        /// </summary>
        /// <returns></returns>
        private static IWebDriver GetDriver()
        {
            string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); //Path to the build directory
            return new ChromeDriver(directory);
        }
    }
}
