using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EndToEndMailCourse._01
{
    [TestFixture]
    public class Workshop01Tests
    {
        private string testUrl = "https://suvroc.github.io/selenium-mail-course/01/workshop.html";

        [Test]
        public void ShouldTestFirstName()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);
            string value = "";
            IWebElement element = null;

            #region TEST CODE

            //Finding element using it's name
            element = driver.FindElement(By.Name("firstName"));
            //Setting element attribute to a variable
            value = element.GetAttribute("value");

            #endregion

            Assert.IsNotNull(element);
            Assert.IsTrue(element is IWebElement);
            Assert.AreEqual(value, "Terry");

            driver.Quit();
        }

        [Test]
        public void ShouldTestLastName()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);
            string value = "";
            IWebElement element = null;

            #region TEST CODE

            //Finding element using it's name
            element = driver.FindElement(By.Name("lastName"));
            //Setting element attribute to a variable
            value = element.GetAttribute("value");

            #endregion

            Assert.IsNotNull(element);
            Assert.IsTrue(element is IWebElement);
            Assert.AreEqual(value, "Pratchett");

            driver.Quit();
        }

        [Test]
        public void ShouldTestCountry()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);
            string value = "";
            IWebElement element = null;

            #region TEST CODE

            //Finding element using it's name
            element = driver.FindElement(By.Name("country"));
            //Setting element attribute to a variable
            value = element.GetAttribute("value");

            #endregion

            Assert.IsNotNull(element);
            Assert.IsTrue(element is IWebElement);
            Assert.AreEqual(value, "England");

            driver.Quit();
        }

        [Test]
        public void ShouldTestActiveCheckbox()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);
            // Changed value type to boolean
            bool value;
            IWebElement element = null;

            #region TEST CODE

            //Finding element using it's Id
            element = driver.FindElement(By.Id("isActive"));
            //Setting element attribute to a variable
            value = element.Enabled;

            #endregion

            Assert.IsNotNull(element);
            Assert.IsTrue(element is IWebElement);
            Assert.AreEqual(element.Enabled, false);
            // Can not compare string to bool, so i've changed value type to bool
            Assert.AreEqual(value, false);

            driver.Quit();
        }

        [Test]
        public void ShouldTestCommentInput()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);
            string value = "";
            IWebElement element = null;

            #region TEST CODE

            //Finding element using it's Id
            element = driver.FindElement(By.Id("commentInput"));
            //Setting element attribute to a variable
            value = element.GetAttribute("value");

            #endregion

            Assert.IsNotNull(element);
            Assert.IsTrue(element is IWebElement);
            Assert.AreEqual(value, "");

            driver.Quit();
        }

        [Test]
        public void ShouldTestDetailsLink()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);
            IWebElement element = null;

            #region TEST CODE

            //Finding element using it's link text
            element = driver.FindElement(By.LinkText("Details"));
            
            #endregion

            Assert.IsNotNull(element);
            Assert.IsTrue(element is IWebElement);
            Assert.AreEqual(element.GetAttribute("href"), @"https://en.wikipedia.org/wiki/Terry_Pratchett");

            driver.Quit();
        }

        [Test]
        public void ShouldTestListOfBooksLink()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            IWebElement element = null;

            #region TEST CODE
            //Finding element using it's partial link text
            element = driver.FindElement(By.PartialLinkText("List of"));
            #endregion

            Assert.IsNotNull(element);
            Assert.IsTrue(element is IWebElement);
            Assert.AreEqual(element.GetAttribute("href"), @"https://www.terrypratchettbooks.com/books/");

            driver.Quit();
        }
    }
}
