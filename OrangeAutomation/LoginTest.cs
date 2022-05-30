using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Fujitsu.OrangeAutomation
{
    public class LoginTest
    {


        [Test]
        public void ValidCredentialTest()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), version: "99.0.4844.51");
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);

            //Navigatr to URL
            driver.Url = "https://opensource-demo.orangehrmlive.com";

            //Enter UserName

            driver.FindElement(By.XPath("//input[@id='txtUsername']")).SendKeys("Admin");

            driver.FindElement(By.XPath("//input[@id='txtPassword']")).SendKeys("admin123");

            driver.FindElement(By.XPath("//input[@id='btnLogin']")).Click();

            string actualURL = driver.Url;

            Assert.That(actualURL, Is.EqualTo("https://opensource-demo.orangehrmlive.com/index.php/dashboard"));


        }
        [Test]

        public void InvalidCredentialTest()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), version: "99.0.4844.51");
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            //Navigatr to URL
            driver.Url = "https://opensource-demo.orangehrmlive.com";

            //Enter UserName

            driver.FindElement(By.XPath("//input[@id='txtUsername']")).SendKeys("Admin");

            driver.FindElement(By.XPath("//input[@id='txtPassword']")).SendKeys("admin23");

            driver.FindElement(By.XPath("//input[@id='btnLogin']")).Click();

            String actualError = driver.FindElement(By.Id("spanMessage")).Text;

            Assert.That(actualError, Is.EqualTo("Invalid credentials"));


        }
    }
}
