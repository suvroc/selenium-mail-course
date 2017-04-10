using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EndToEndMailCourse._02
{
    [TestFixture]
    public class Workshop02Tests
    {
        private string testUrl = "https://suvroc.github.io/selenium-mail-course/02/workshop.html";

        [Test]
        public void ShouldTestWorkshop2Page()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);
            string name = "Test name";
            string comment = "Test comment";
            IWebElement nameResult = null,
                commentResult = null;                

            #region TEST CODE

            #endregion

            nameResult = driver.FindElement(By.Id("savedTaskName"));
            commentResult = driver.FindElement(By.Id("savedComment"));
            var nameInput = driver.FindElement(By.Id("taskNameInput"));
            var commentInput = driver.FindElement(By.Id("commentInput"));

            nameInput.SendKeys("Test name");

            var button = driver.FindElement(By.Id("showDetailsButton"));
            button.Click();

            commentInput.SendKeys("Test comment");
            commentInput.SendKeys(Keys.Enter);

            Assert.NotNull(nameResult);
            Assert.AreEqual(nameResult.Text, name);
            Assert.IsTrue(nameResult.Displayed);

            Assert.NotNull(commentResult);
            Assert.AreEqual(commentResult.Text, comment);
            Assert.IsTrue(nameResult.Displayed);

            

            driver.Quit();
        }
    }
}
