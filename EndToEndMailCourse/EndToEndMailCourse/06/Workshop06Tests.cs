using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace EndToEndMailCourse._06
{
    [TestFixture]
    public class Workshop06Tests
    {
        private string testUrl = "https://suvroc.github.io/selenium-mail-course/06/workshop.html";

        [Test]
        public void ShouldTestOnMobile()
        {
            #region TEST CODE
            var options = new ChromeOptions();
            options.EnableMobileEmulation(new ChromeMobileEmulationDeviceSettings()
            {
                EnableTouchEvents = true,
                Width = 412,
                Height = 732,
                UserAgent = "Chrome"
            });

            var driver = new ChromeDriver();

            #endregion

            driver.Navigate().GoToUrl(testUrl);

            var menu = driver.FindElement(By.ClassName("menu"));
            var content = driver.FindElement(By.ClassName("content"));
            var advert = driver.FindElement(By.ClassName("advert"));

            Assert.AreEqual(menu.TagName, "div");
            Assert.IsTrue(menu.Displayed);
            Assert.AreEqual(content.TagName, "div");
            Assert.IsTrue(content.Displayed);
            Assert.AreEqual(advert.TagName, "div");
            Assert.IsFalse(advert.Displayed);

            driver.Quit();
        }

        [Test]
        public void ShouldTestOnDesktop()
        {
            #region TEST CODE
            var options = new ChromeOptions();
            options.EnableMobileEmulation(new ChromeMobileEmulationDeviceSettings()
            {
                EnableTouchEvents = true,
                Width = 1024,
                Height = 768,
                UserAgent = "Chrome"
            });
            var driver = new ChromeDriver();

            #endregion

            driver.Navigate().GoToUrl(testUrl);

            var menu = driver.FindElement(By.ClassName("menu"));
            var content = driver.FindElement(By.ClassName("content"));
            var advert = driver.FindElement(By.ClassName("advert"));

            Assert.AreEqual(menu.TagName, "div");
            Assert.IsTrue(menu.Displayed);
            Assert.AreEqual(content.TagName, "div");
            Assert.IsTrue(content.Displayed);
            Assert.AreEqual(advert.TagName, "div");
            Assert.IsTrue(advert.Displayed);

            driver.Quit();
        }
    }
}
