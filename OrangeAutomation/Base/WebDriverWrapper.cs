using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Fujitsu.OrangeAutomation.Base
{
    public class WebDriverWrapper
    {
        protected ChromeDriver driver;

        [SetUp]
        public void Init()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(), version: "99.0.4844.51");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);

            //Navigatr to URL
            driver.Url = "https://opensource-demo.orangehrmlive.com";
        }


        [TearDown]
        public void End()
        {
            driver.Quit();
        }

    }
}
