using NUnit.Framework;
//using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace Homework52
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
        //[Test]
        [TestCase("JohnDoe", "paoword")]
        public void SimpleTestCase(string v1, string v2) 
        {
            //WebDriver driver = GetDriver();
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            string url = "http://automationpractice.com/";
            driver.Navigate().GoToUrl(url);
            IWebElement loginhref = driver.FindElement(By.CssSelector(".login"));
            loginhref.Click();
            // string basurl = "https://itschool.kherson.dataart.com/lecture/attachments/video/21";
            //IWebDriver driver1 = new FirefoxDriver();
            // driver1.Get(basurl);
             IWebElement loginInput = driver.FindElement(By.CssSelector("#login_form .account_input"));
            loginInput.SendKeys(v1);
            IWebElement passwordInput = driver.FindElement(By.Id("passwd"));
            passwordInput.SendKeys(v2);
            IWebElement loginhref1 = driver.FindElement(By.Id("SubmitLogin"));
            loginhref1.Click();
            IWebElement errormsg = driver.FindElement(By.CssSelector(".alert.alert-danger"));
            Assert.IsEmpty(errormsg.ToString(), "Invalid email address");
        }
       [OneTimeTearDown]
       public void AfterTest()
        {
          driver.Quit();
        }
    }
}

