using NUnit.Framework;
//using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace Homework5
{
    [TestFixture]

    public class MyTestClass
    {
        IWebDriver driver;
        //[SetUp]
        [OneTimeSetUp]
        public void BeforeTest()
        {
            driver = new FirefoxDriver();
        }
        [Test]
        public void testCase1()
        {
            //IWebDriver driver = GetDriver();
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            string url = "https://www.demoblaze.com/index.html";
            driver.Navigate().GoToUrl(url);
            IWebElement loginhref = driver.FindElement(By.Id("login2"));
            loginhref.Click();
            IWebElement loginInput = driver.FindElement(By.XPath("//input[@id='loginusername']"));
            loginInput.SendKeys("Lidia");
            IWebElement passwordInput = driver.FindElement(By.CssSelector("input[id = 'loginpassword']"));
            passwordInput.SendKeys("12345");
            IWebElement loginButton = driver.FindElement(By.CssSelector("#logInModal .btn-primary"));
            loginButton.Click();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(x => x.FindElement(By.Id("nameofuser")).Displayed);
            //driver.Quit();
        }


       [OneTimeTearDown]
       public void AfterTest()
       {
           driver.Quit();
        }
        //private static IWebDriver GetDriver()
        //{
        //   string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); //Path to the build directory
        //  return new FirefoxDriver(directory);
        //}
    }
}
