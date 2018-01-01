using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EndToEndCourse._01
{
    [TestFixture]
    public class Example01Tests
    {
        private string testUrl = "https://suvroc.github.io/selenium-course/01/example.html";

        [Test]
        public void FirstTest()
        {
            Assert.IsTrue(2 + 2 == 4);
        }


        [Test]
        public void ShouldTestIdElement()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            var element = driver.FindElement(By.Id("elementWithId"));

            Assert.IsNotNull(element);
            Assert.AreEqual(element.GetAttribute("value"), "Test data");

            driver.Quit();
        }

        [Test]
        public void ShouldTestNameElement()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            var element = driver.FindElement(By.Name("elementWithName"));

            Assert.IsNotNull(element);
            Assert.AreEqual(element.GetAttribute("value"), "Name test data");

            driver.Quit();
        }

        [Test]
        public void ShouldTestClassElement()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            var element = driver.FindElement(By.ClassName("elementWithClass"));

            Assert.IsNotNull(element);
            Assert.AreEqual(element.GetAttribute("value"), "Class test data");

            driver.Quit();
        }

        [Test]
        public void ShouldTestDisabledClassElement()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            var element = driver.FindElement(By.ClassName("disabledElementWithClass"));

            Assert.IsNotNull(element);
            Assert.AreEqual(element.GetAttribute("value"), "Disabled test data");
            Assert.AreEqual(element.Enabled, false);

            driver.Quit();
        }

        [Test]
        public void ShouldTestLinks()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            var element = driver.FindElement(By.LinkText("Test link"));

            Assert.IsNotNull(element);

            element = driver.FindElement(By.PartialLinkText("longer test"));

            Assert.IsNotNull(element);

            driver.Quit();
        }
    }
}
