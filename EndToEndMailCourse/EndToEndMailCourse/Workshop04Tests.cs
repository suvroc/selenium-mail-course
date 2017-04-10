using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;

namespace EndToEndMailCourse._04
{
    [TestFixture]
    public class Workshop04Tests
    {
        private string testUrl = "https://suvroc.github.io/selenium-mail-course/04/workshop.html";

        [Test]
        public void ShouldCheckSelectedBookName()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            string firstName = "Mark",
                lastName = "Twain",
                street = "Garden",
                town = "London";

            var personalDataPage = new PersonalDataPage(driver);
            personalDataPage.FirstNameInput.SendKeys(firstName);
            personalDataPage.LastNameInput.SendKeys(lastName);

            personalDataPage.NextButton.Click();

            Assert.AreEqual(driver.Url, "https://suvroc.github.io/selenium-mail-course/04/workshop1.html?firstName=Mark&lastName=Twain");
       
            var addressPage = new AddressPage(driver);

            addressPage.StreetInput.SendKeys(street);
            addressPage.TownInput.SendKeys(town);

            addressPage.NextButton.Click();

            Assert.AreEqual(driver.Url, "https://suvroc.github.io/selenium-mail-course/04/workshop2.html?firstName=Mark&lastName=Twain&street=Garden&town=London");
       

            var finalPage = new FinalPage(driver);

            Assert.AreEqual(finalPage.FirtsNameText.Text, firstName);
            Assert.AreEqual(finalPage.LastNameText.Text, lastName);
            Assert.AreEqual(finalPage.StreetText.Text, street);
            Assert.AreEqual(finalPage.TownText.Text, town);

            driver.Quit();
        }
    }

    public class PersonalDataPage
    {
        private readonly IWebDriver _driver;

        public PersonalDataPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement FirstNameInput
        {
            get { return _driver.FindElement(By.Id("firstNameInput")); }
        }

        public IWebElement LastNameInput
        {
            get { return _driver.FindElement(By.Id("lastNameInput")); }
        }

        public IWebElement NextButton
        {
            get { return _driver.FindElement(By.Id("nextButton")); }
        }


    }

    public class AddressPage
    {
        private readonly IWebDriver _driver;

        public AddressPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement StreetInput
        {
            get { return _driver.FindElement(By.Id("streetInput")); }
        }

        public IWebElement TownInput
        {
            get { return _driver.FindElement(By.Id("townInput")); }
        }

        public IWebElement NextButton
        {
            get { return _driver.FindElement(By.Id("nextButton")); }
        }
    }

    public class FinalPage
    {
        private readonly IWebDriver _driver;

        public FinalPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement FirtsNameText
        {
            get { return _driver.FindElement(By.Id("firstNameText")); }
        }

        public IWebElement LastNameText
        {
            get { return _driver.FindElement(By.Id("lastNameText")); }
        }

        public IWebElement StreetText
        {
            get { return _driver.FindElement(By.Id("streetText")); }
        }

        public IWebElement TownText
        {
            get { return _driver.FindElement(By.Id("townText")); }
        }

    }
}
