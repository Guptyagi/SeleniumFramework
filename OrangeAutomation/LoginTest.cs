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

        public static object[] InvalidTestData()
        {
            object[] temp1 = new object[3];
            temp1[0] = "John";
            temp1[1] = "John123";
            temp1[2] = "Invalid credentials";
            object[] temp2 = new object[3];
            temp2[0] = "Wick";
            temp2[1] = "Wick123";
            temp2[2] = "Invalid credentials";
            object[] temp3 = new object[3];
            temp3[0] = "Sara";
            temp3[1] = "Sara123";
            temp3[2] = "Invalid credentials";
            object[] temp4 = new object[3];
            temp4[0] = "Jene";
            temp4[1] = "Jene123";
            temp4[2] = "Invalid credentials";
            object[] main = new object[4];
            main[0] = temp1;
            main[1] = temp2;
            main[2] = temp3;
            main[3] = temp4;



            return main;
        }
        //[Test, Order(2)]
        [Test,TestCaseSource(nameof(InvalidTestData))]
        /*[TestCase("John", "Wick", "Invalid credentials")]
        [TestCase("Peter", "England", "Invalid credentials")]
*/
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
