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

            var addressPage = new AddressPage(driver);

            addressPage.StreetInput.SendKeys(street);
            addressPage.TownInput.SendKeys(town);

            addressPage.NextButton.Click();

            var finalPage = new FinalPage(driver);

            Assert.AreEqual(finalPage.FirstName.Text, firstName);
            Assert.AreEqual(finalPage.LastName.Text, lastName);
            Assert.AreEqual(finalPage.Street.Text, street);
            Assert.AreEqual(finalPage.Town.Text, town);

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

        #region TEST CODE
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
        #endregion
    }

    public class AddressPage
    {
        private readonly IWebDriver _driver;

        public AddressPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region TEST CODE
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
        #endregion
    }

    public class FinalPage
    {
        private readonly IWebDriver _driver;

        public FinalPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region TEST CODE
        public IWebElement FirstName
        {
            get { return _driver.FindElement(By.Id("firstNameText")); }
        }

        public IWebElement LastName
        {
            get { return _driver.FindElement(By.Id("lastNameText")); }
        }

        public IWebElement Street
        {
            get { return _driver.FindElement(By.Id("streetText")); }
        }

        public IWebElement Town
        {
            get { return _driver.FindElement(By.Id("townText")); }
            #endregion
        }
    }
}
