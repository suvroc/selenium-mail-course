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
            // Declare page elements
            IWebElement inputField = driver.FindElement(By.Id("taskNameInput"));
            IWebElement showDetailsButton = driver.FindElement(By.Id("showDetailsButton"));

            //Actions on elements

            //Entering text into input
            inputField.SendKeys(name);
            inputField.SendKeys(Keys.Enter);

            //Clicking on button
            showDetailsButton.Click();
            IWebElement inputField2 = driver.FindElement(By.Id("commentInput"));

            //Entering text into input
            inputField2.SendKeys(comment);
            inputField.SendKeys(Keys.Enter);

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
