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
            var taskNameInput = driver.FindElement(By.Id("taskNameInput"));
            taskNameInput.SendKeys("Test name");
            taskNameInput.SendKeys(Keys.Enter);
            var showDetailsButton = driver.FindElement(By.Id("showDetailsButton"));
            showDetailsButton.Click();
            var commentInput = driver.FindElement(By.Id("commentInput"));
            commentInput.SendKeys("Test comment");
            commentInput.SendKeys(Keys.Enter);
            #endregion

            nameResult = driver.FindElement(By.Id("savedTaskName"));
            commentResult = driver.FindElement(By.Id("savedComment"));

            Assert.NotNull(nameResult);
            Assert.AreEqual(nameResult.TagName, "div");
            Assert.AreEqual(nameResult.Text, name);
            Assert.IsTrue(nameResult.Displayed);

            Assert.NotNull(commentResult);
            Assert.AreEqual(commentResult.TagName, "div");
            Assert.AreEqual(commentResult.Text, comment);
            Assert.IsTrue(nameResult.Displayed);

            driver.Quit();
        }
    }
}
