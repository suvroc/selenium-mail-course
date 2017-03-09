using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EndToEndMailCourse._04
{
    [TestFixture]
    public class Example04Tests
    {
        private string testUrl = "https://suvroc.github.io/selenium-mail-course/04/example.html";


        [Test]
        public void ShouldTestExamplePage()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            var firstPage = new ExamplePage1(driver);

            firstPage.Input1.SendKeys("Test text 1");

            firstPage.Input2.SendKeys("Test text 2");

            firstPage.Input3.SendKeys("Test text 3");

            firstPage.NextButton.Click();

            Assert.AreEqual(driver.Url, "https://suvroc.github.io/selenium-mail-course/04/example1.html");

            var secondPage = new ExamplePage2(driver);

            secondPage.BackButton.Click();

            Assert.AreEqual(driver.Url, "https://suvroc.github.io/selenium-mail-course/04/example.html");

            driver.Quit();
        }
    }

    public class ExamplePage1
    {
        private readonly IWebDriver _driver;

        public ExamplePage1(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement Input1
        {
            get { return _driver.FindElement(By.Id("input1")); }
        }

        public IWebElement Input2
        {
            get { return _driver.FindElement(By.Id("input2")); }
        }

        public IWebElement Input3
        {
            get { return _driver.FindElement(By.Id("input3")); }
        }

        public IWebElement NextButton
        {
            get { return _driver.FindElement(By.Id("nextButton")); }
        }
    }

    public class ExamplePage2
    {
        private readonly IWebDriver _driver;

        public ExamplePage2(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement BackButton
        {
            get { return _driver.FindElement(By.Id("backButton")); }
        }
    }
}
