
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EndToEndMailCourse._01
{
    [TestFixture]
    public class FirstTestClass
    {
        private string testUrl = "https://suvroc.github.io/selenium-mail-course/01/example.html";

        [Test]
        public void FirstTest()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);


            driver.Quit();
        }

        [Test]
        public void ShouldTestFirstName()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            var element = driver.FindElement(By.Name("elementWithName"));
            Assert.IsNotNull(element);
            Assert.AreEqual(element.GetAttribute("value"), "Name test data");

            driver.Quit();
        }
    }
}

