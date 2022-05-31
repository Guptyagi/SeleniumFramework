using Fujitsu.OrangeAutomation.Base;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeAutomation
{
    public class LoginUITest : WebDriverWrapper
    {
        
        [Test]
        public void ValidateTitleTest()
        {

            Assert.That(driver.Title, Is.EqualTo("OrangeHRM"));

        }
    }
}
