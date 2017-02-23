using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EndToEndMailCourse._02
{
    [TestFixture]
    public class Example02Tests
    {
        private string testUrl = "https://suvroc.github.io/selenium-mail-course/02/example.html";


        [Test]
        public void ShouldTestExamplePage()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            var navigateButton = driver.FindElement(By.Id("naviagtionButton"));
            navigateButton.Click();
            var nextPageText = driver.FindElement(By.Id("embeddedElement"));
            Assert.AreEqual(nextPageText.Text, "External text");
            driver.Navigate().Back();


            driver.SwitchTo().Frame(driver.FindElement(By.Id("iframeElement")));

            var embeddedPageText = driver.FindElement(By.Id("embeddedElement"));
            Assert.AreEqual(embeddedPageText.Text, "External text");

            driver.SwitchTo().ParentFrame();
            // check text in iframe

            var showTextButton = driver.FindElement(By.Id("showText"));
            showTextButton.Click();
            var hiddenText = driver.FindElement(By.Id("hiddenText"));
            Assert.AreEqual(hiddenText.Text, "Some hidden text");

            var syncInput = driver.FindElement(By.Id("syncInput"));
            string testData = "testData";
            syncInput.SendKeys(testData);
            syncInput.SendKeys(Keys.Enter);

            var syncText = driver.FindElement(By.Id("syncText"));
            Assert.AreEqual(syncText.Text, testData);
           
            driver.Quit();
        }

        
    }
}
