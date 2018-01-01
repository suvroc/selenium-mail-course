using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;

namespace EndToEndCourse._07
{
    [TestFixture]
    public class Workshop07Tests
    {
        private string testUrl = "https://suvroc.github.io/selenium-course/07/workshop.html";

        [Test]
        public void ShouldSelectAnswers()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            var companySelectElement = driver.FindElement(By.Id("companySelect"));
            var carSelectElement = driver.FindElement(By.Id("carSelect"));

            #region TEST CODE

            #endregion

            Assert.AreEqual(driver.FindElements(By.ClassName("list-group-item")).Count(), 6);


            driver.Quit();
        }
    }
}
