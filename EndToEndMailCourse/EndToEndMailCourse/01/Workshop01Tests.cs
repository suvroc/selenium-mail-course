﻿using NUnit.Framework;
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
            element = driver.FindElementByName("firstName");
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
            element = driver.FindElementByName("lastName");
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
            element = driver.FindElementByName("country");
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
            bool value = true;
            IWebElement element = null;

            #region TEST CODE
            element = driver.FindElementById("isActive");
            value = element.Selected;
            #endregion

            Assert.IsNotNull(element);
            Assert.IsTrue(element is IWebElement);
            Assert.AreEqual(element.Enabled, false);
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
            element = driver.FindElementById("commentInput");
            value = element.GetAttribute("placeholder");
            #endregion

            Assert.IsNotNull(element);
            Assert.IsTrue(element is IWebElement);
            Assert.AreEqual(value, "Enter your comment");

            driver.Quit();
        }

        [Test]
        public void ShouldTestDetailsLink()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);
            IWebElement element = null;

            #region TEST CODE
            element = driver.FindElementByPartialLinkText("Details");
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
            element = driver.FindElementByPartialLinkText("List");

            #endregion

            Assert.IsNotNull(element);
            Assert.IsTrue(element is IWebElement);
            Assert.AreEqual(element.GetAttribute("href"), @"https://www.terrypratchettbooks.com/books/");

            driver.Quit();
        }
    }
}