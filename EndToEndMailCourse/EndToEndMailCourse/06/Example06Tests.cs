using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace EndToEndMailCourse._06
{
    [TestFixture]
    public class Example06Tests
    {
        private string testUrl = "https://suvroc.github.io/selenium-mail-course/06/example.html";


        [Test]
        public void ShouldTestOnSmartphone()
        {
            var options = new ChromeOptions();
            options.EnableMobileEmulation(new ChromeMobileEmulationDeviceSettings()
            {
                EnableTouchEvents = true,
                Width = 412,
                Height = 732,
                UserAgent = "Chrome"
            });
            var driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(testUrl);

            var element = driver.FindElement(By.Id("xs-block"));

            Assert.IsTrue(element.Displayed);

            driver.Quit();
        }

        [Test]
        public void ShouldTestOnTablet()
        {
            var options = new ChromeOptions();
            options.EnableMobileEmulation(new ChromeMobileEmulationDeviceSettings()
            {
                EnableTouchEvents = true,
                Width = 768,
                Height = 1024,
                UserAgent = "Chrome"
            });
            var driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(testUrl);

            var element = driver.FindElement(By.Id("sm-block"));

            Assert.IsTrue(element.Displayed);

            driver.Quit();
        }

        [Test]
        public void ShouldTestOnDesktop()
        {
            var options = new ChromeOptions();
            options.EnableMobileEmulation(new ChromeMobileEmulationDeviceSettings()
            {
                EnableTouchEvents = true,
                Width = 1024,
                Height = 768,
                UserAgent = "Chrome"
            });
            var driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(testUrl);

            var element = driver.FindElement(By.Id("md-block"));

            Assert.IsTrue(element.Displayed);

            driver.Quit();
        }


    }
}
