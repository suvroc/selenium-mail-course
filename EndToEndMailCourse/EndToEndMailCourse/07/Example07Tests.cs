using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace EndToEndMailCourse._07
{
    [TestFixture]
    public class Example07Tests
    {
        private string testUrl = "https://suvroc.github.io/selenium-mail-course/07/example.html";


        [Test]
        public void ShouldClickAllButtons()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            var waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            var firstButton = driver.FindElement(By.Id("firstButton"));

            firstButton.Click();

            var secondButton = waiter
                .Until(ExpectedConditions.ElementToBeClickable(By.Id("secondButton")));

            secondButton.Click();

            var thirdButton = waiter
                .Until(ExpectedConditions.ElementToBeClickable(By.Id("thirdButton")));

            thirdButton.Click();

            var finalText = waiter
                .Until(ExpectedConditions.ElementToBeClickable(By.Id("finalText")));

            Assert.IsTrue(finalText.Text.Contains("Congratulations"));

            driver.Quit();
        }

        
    }
}
