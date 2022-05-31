using Fujitsu.OrangeAutomation.Base;
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
    public class LoginTest : WebDriverWrapper
    {
        


        [Test, Order(1)]
        [TestCase("Admin","admin123", "https://opensource-demo.orangehrmlive.com/index.php/dashboard")]
        [TestCase("Admin","admin123", "https://opensource-demo.orangehrmlive.com/index.php/dashboard")]
        public void ValidCredentialTest(string username, string password, string expectedURL)
        {
            

            //Enter UserName

            driver.FindElement(By.XPath("//input[@id='txtUsername']")).SendKeys(username);

            driver.FindElement(By.XPath("//input[@id='txtPassword']")).SendKeys(password);

            driver.FindElement(By.XPath("//input[@id='btnLogin']")).Click();

            string actualURL = driver.Url;

            Assert.That(actualURL, Is.EqualTo(expectedURL));


        }
        [Test, Order(2)]
        [TestCase("John", "Wick", "Invalid credentials")]
        [TestCase("Peter", "England", "Invalid credentials")]

        public void InvalidCredentialTest(string username, string password, string expectedError)
        {
            
            //Enter UserName

            driver.FindElement(By.XPath("//input[@id='txtUsername']")).SendKeys(username);

            driver.FindElement(By.XPath("//input[@id='txtPassword']")).SendKeys(password);

            driver.FindElement(By.XPath("//input[@id='btnLogin']")).Click();

            String actualError = driver.FindElement(By.Id("spanMessage")).Text;

            Assert.That(actualError, Is.EqualTo(expectedError));


        }
    }
}
