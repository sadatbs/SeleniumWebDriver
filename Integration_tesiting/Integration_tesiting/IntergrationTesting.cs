using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Inegration_Testing
{
    class ITesting
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void test()
        {
            driver.Url = "https://elp.duetbd.org/login/index.php";
            IWebElement element = driver.FindElement(By.XPath("//*[@id='username']"));
            element.SendKeys("170042068");
            IWebElement password = driver.FindElement(By.XPath("//*[@id='password']"));
            password.SendKeys("Abc.1234");
            driver.FindElement(By.XPath("//*[@id='loginbtn']")).Click();
            String at = driver.Title;
            String et = "Dashboard";
            if (at == et)
            {
                Console.WriteLine("Test Successful");
                
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}